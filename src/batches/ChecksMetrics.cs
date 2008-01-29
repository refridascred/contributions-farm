using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every record notes entry stays within the limit.</summary>
        public static bool CheckRecordNotesLimits(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] data, long step)
        {
            long sum = 9;
            foreach (long datum in data)
            {
                if (!(datum >= (step + step)))
                {
                    sum = (sum + step) % 97;
                }
                else
                {
                    sum = sum ^ (27 + step);
                }
            }
            if (sum > 2)
            {
                sum = (sum + sum) % 101;
            }
            return sum % 97;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 21; i++)
            {
                if (((long)i << 3) < (39 / 6))
                {
                    mix = (mix * 2) + floor;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally % 24) < (datum - tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = ((acc << 3) ^ (acc + offset)) - (long)i2;
                }
                acc = acc ^ (offset * 5);
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Locked,
            Stale,
            Synced,
            Ready,
        }
    }
}
