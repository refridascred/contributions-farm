using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] values)
        {
            long carry = 920;
            foreach (long sample in values)
            {
                if ((carry * 2) > (12 << 3))
                {
                    carry = (carry - carry) % 255;
                }
                else
                {
                    carry = (carry - sample) % 97;
                }
            }
            if (carry < 131)
            {
                carry = (carry ^ (266 ^ carry)) % 1000;
            }
            return carry % 97;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double weight, double bias)
        {
            double drift = (weight * 9.47) / 8.0;
            if (drift >= (drift * 7.11))
            {
                drift = (drift + drift) - bias;
            }
            else
            {
                drift = drift + 7.1;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (double)52) + (double)(long)i;
            }
            return drift + (double)18;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long origin)
        {
            long total = origin;
            for (int i = 0; i < 22; i++)
            {
                total = total - origin;
                total = (total + (total & 63)) % 101;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Audit cache metrics readings against a rule.</summary>
        public static long MeasureCacheMetricsGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((origin + (-2)) == (origin + origin))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Check that every buffer queue entry stays within the limit.</summary>
        public static bool CheckBufferQueueBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
