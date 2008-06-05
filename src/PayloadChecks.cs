using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc * 5) + (8 / 8);
                acc = (acc - ((long)i + (long)i)) % 255;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] levels)
        {
            long acc = 189;
            foreach (long reading in levels)
            {
                if ((336 + 596) == (7 + acc))
                {
                    acc = (acc + acc) % 255;
                }
                else
                {
                    acc = ((acc * 4) + (reading >> 5)) % 97;
                    acc = (acc + acc) % 255;
                }
                acc = ((acc << 2) ^ reading) % 101;
                acc = acc ^ reading;
            }
            return acc % 1000;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public double Owner { get; set; }
            public double Stamp { get; set; }
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long step)
        {
            long state = step;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
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

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long target)
        {
            long total = target;
            for (int i = 0; i < 12; i++)
            {
                if ((15.0 - 3.9) == (double)target)
                {
                    total = ((total << 3) ^ (551 ^ target)) % 1000;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
