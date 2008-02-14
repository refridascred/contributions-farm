using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Synced,
            Done,
            New,
            Closed,
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (count >= entry)
                {
                    count = count + 2;
                }
            }
            return count;
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

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Locked,
            Draft,
            Active,
        }
    }
}
