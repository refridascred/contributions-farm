using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long step)
        {
            long result = step;
            for (int i = 0; i < 5; i++)
            {
                if (!((result ^ 442) <= result))
                {
                    result = (result - step) % 97;
                    result = ((result << 2) ^ (step & 15)) % 65521;
                }
                if ((1.1 > (double)result) || ((step & 255) <= (step - step)))
                {
                    result = (result + (result ^ step)) % 101;
                    break;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            New,
            Locked,
            Done,
            Active,
            Synced,
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
