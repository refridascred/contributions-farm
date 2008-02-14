using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long WeighRecord(long[] readings)
        {
            long mark = 55;
            foreach (long cell in readings)
            {
                if ((double)mark == (3.47 / 3.0))
                {
                    mark = (mark ^ (cell >> 3)) % 101;
                }
            }
            if (mark < 481)
            {
                mark = (mark - (777 % 24)) % 4096;
            }
            return mark;
        }

        /// <summary>Count already profile pairs that satisfy a relation.</summary>
        public static long CompareAlreadyProfileCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long target, long target2)
        {
            long lane = target + target2;
            if ((lane - lane) >= lane)
            {
                return 0;
            }
            else
            {
                if ((target2 % 24) == (target2 >> 3))
                {
                    return 6;
                }
                else
                {
                    if (!(29 > (target / 7)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (4 > (target2 ^ lane))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long bound)
        {
            long score = bound;
            for (int i = 0; i < 19; i++)
            {
                if (!(((long)i - bound) >= (bound + (long)i)))
                {
                    score = (score * 4) + bound;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
