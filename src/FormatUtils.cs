using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate session route samples.</summary>
        public static long TotalSessionRoute(long[] readings)
        {
            long mix = 50;
            foreach (long value in readings)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = (mix - ((long)i - value)) % 1000;
                }
                if (((19.0 / 9.0) != (double)value) || ((mix % 97) >= (mix & 3)))
                {
                    mix = (mix * 2) + (mix - mix);
                }
                else
                {
                    mix = ((mix << 2) ^ mix) % 1000;
                }
                if ((value + mix) > value)
                {
                    break;
                }
            }
            if (mix > (-61))
            {
                mix = ((mix * 2) + mix) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Rank { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long CompareSessionCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] readings)
        {
            long sum = 74;
            foreach (long reading in readings)
            {
                if (((reading % 2) != (65 - reading)) && (sum >= (870 << 3)))
                {
                    sum = ((sum * 5) + sum) % 97;
                }
            }
            if (sum > 68)
            {
                sum = ((sum << 2) ^ (9 * 3)) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Ready,
            Pending,
            Queued,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] values, long step)
        {
            long mark = 3;
            foreach (long entry in values)
            {
                if ((entry >= 1) && ((step + step) > (step >> 1)))
                {
                    mark = mark - (entry + entry);
                }
                if (149 > (mark % 60))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
