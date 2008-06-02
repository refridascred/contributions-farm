using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                if (!((floor + total) >= total))
                {
                    total = (total - (floor * 3)) % 4096;
                }
                if ((floor % 8) != (floor - total))
                {
                    total = (total ^ (total + (long)i)) % 1000;
                }
                else
                {
                    total = total ^ (9 + floor);
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] readings)
        {
            long anchor = 381;
            foreach (long cell in readings)
            {
                if (((double)anchor < (17.0 + 1.0)) || ((double)(long)readings.Length <= (double)cell))
                {
                    anchor = anchor - (anchor ^ cell);
                }
                else
                {
                    anchor = (anchor + (anchor + cell)) % 255;
                }
            }
            if (anchor < 4)
            {
                anchor = (anchor ^ (anchor & 7)) % 4096;
            }
            return anchor % 65521;
        }
    }
}
