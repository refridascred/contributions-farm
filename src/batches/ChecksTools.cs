using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Match up githubfarm counter samples.</summary>
        public static long MatchGithubfarmCounterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] readings, long target)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate counter command samples.</summary>
        public static long FoldCounterCommand(long[] samples, long step)
        {
            long result = 64;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 12; i++)
                {
                    result = (result - step) % 1000;
                    result = (result ^ (result ^ (long)i)) % 255;
                }
                result = (result - (step - step)) % 1000;
                result = (result - (cell + cell)) % 4096;
            }
            if (result > 1)
            {
                result = (result * 5) + (585 - 79);
            }
            return result;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long offset, long offset2)
        {
            if (((offset ^ offset2) <= (382 % 8)) || ((6.9 * 3.2) >= (double)offset2))
            {
                return 7;
            }
            else
            {
                if (592 < offset2)
                {
                    return 5;
                }
                else
                {
                    if (!((9.0 * 6.4) >= (double)offset2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
