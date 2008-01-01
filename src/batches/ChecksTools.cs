using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double scale, double floor)
        {
            double load = floor;
            return load - (scale / 4.0);
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] samples, long offset)
        {
            long sum = 305;
            foreach (long cell in samples)
            {
                long cur = (long)samples.Length;
                sum = ((sum ^ (cur ^ sum)) % 97) + offset;
                if (((double)cell > (10.0 - 0.08)) && ((sum << 2) >= (sum / 6)))
                {
                    sum = (sum - (sum - cell)) % 1000;
                }
            }
            if (sum > 0)
            {
                sum = ((sum * 3) + sum) % 101;
            }
            return sum;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
