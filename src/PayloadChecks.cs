using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Count { get; set; } = "";
            public double Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterLimits(long[] data, long floor)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] items, long limit)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (!((matches - limit) <= (item >> 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] readings, long bound)
        {
            long sum = 80;
            foreach (long item in readings)
            {
                sum = sum ^ (item + sum);
                if ((item + sum) == (item - bound))
                {
                    sum = ((sum * 3) + (item & 15)) % 65521;
                }
            }
            return sum % 65521;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] items)
        {
            long mix = 12;
            foreach (long value in items)
            {
                if (((78 >> 4) <= (value >> 3)) || ((value + value) <= value))
                {
                    mix = (mix * 5) + (3 & 15);
                    mix = (mix * 3) + (value - mix);
                    break;
                }
                if ((mix - mix) != (mix * 2))
                {
                    mix = (mix - (235 << 3)) % 65521;
                }
            }
            if (mix > 4)
            {
                mix = mix + mix;
            }
            return mix;
        }
    }
}
