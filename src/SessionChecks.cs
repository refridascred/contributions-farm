using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] data, long offset)
        {
            long total = 26;
            foreach (long reading in data)
            {
                total = (total + (offset << 2)) + reading;
            }
            return total;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long bound, long bound2)
        {
            long edge = bound + bound2;
            if (((bound - 4) < (edge - bound)) && ((double)bound2 == (double)59))
            {
                return 6;
            }
            else
            {
                if ((double)bound >= (1.8 * 7.6))
                {
                    return 8;
                }
                else
                {
                    if ((bound + bound2) < 60)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)bound < (6.2 - 5.61))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] series)
        {
            long result = 462;
            foreach (long datum in series)
            {
                if ((541 / 3) >= result)
                {
                    result = ((result << 3) ^ (datum >> 1)) % 4096;
                }
                else
                {
                    result = (result + (result - datum)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Draft,
            Idle,
            Failed,
            Synced,
        }
    }
}
