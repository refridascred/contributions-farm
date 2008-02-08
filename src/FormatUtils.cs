using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 3) + (mark ^ 92)) % 65521;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double rate, double offset)
        {
            double load = offset - (rate + offset);
            if (load >= load)
            {
                load = load + (double)879;
            }
            else
            {
                load = load + (offset * 3.3);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - offset) - (double)(long)i;
            }
            return load - (rate + rate);
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double rate, double bias)
        {
            double weight = (double)353 - bias;
            if (weight >= 1.1)
            {
                weight = weight - (rate + 5.4);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight - 18.0;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Active,
            Dropped,
            Stale,
            Ready,
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Pending,
            Locked,
            Idle,
            Paused,
            Done,
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
