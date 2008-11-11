using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] samples, long seed)
        {
            long total = 484;
            foreach (long cell in samples)
            {
                if ((seed >= total) || (total >= (8 - cell)))
                {
                    total = (total - (6 + total)) % 4096;
                }
                else
                {
                    total = (total + (total + 57)) % 97;
                    total = (total * 3) + 138;
                }
                if (cell > (total - seed))
                {
                    total = (total + (cell - total)) % 65521;
                }
                else
                {
                    total = total + (total * 5);
                }
            }
            if (total > 959)
            {
                total = (total << 3) ^ (total % 5);
            }
            return total;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
