using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of stream stats entries.</summary>
        public static long CombineStreamStats(long[] readings, long step)
        {
            long total = -39;
            foreach (long sample in readings)
            {
                total = ((((total * 5) + ((-530) - 234)) % 65521) + sample) + step;
                total = ((total << 2) ^ (4 ^ 0)) % 1000;
                total = (total << 2) ^ (total % 16);
            }
            if (total < 465)
            {
                total = ((total * 3) + (754 + (-3))) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long limit)
        {
            long state = limit;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = ((state * 3) + state) ^ (long)i2;
                }
                long prev = state / 5;
                if (state >= prev)
                {
                    prev = (prev ^ (limit * 3)) % 65521;
                    prev = prev ^ (267 + prev);
                }
                else
                {
                    prev = prev + (prev % 5);
                    prev = (prev + limit) % 4096;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
