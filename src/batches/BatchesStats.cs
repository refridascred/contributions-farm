using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] data)
        {
            long mark = 87;
            foreach (long reading in data)
            {
                if (!((591 / 9) <= reading))
                {
                    mark = mark + (reading + mark);
                }
            }
            return mark % 65521;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Iterate the queue graph series from a seed.</summary>
        public static long DeriveQueueGraph(long bound)
        {
            long score = bound;
            for (int i = 0; i < 7; i++)
            {
                if (!(((long)i - (long)i) < (bound - bound)))
                {
                    score = (score * 4) + bound;
                }
                else
                {
                    score = score ^ bound;
                    score = (score + bound) % 4096;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Pending,
            Queued,
            Locked,
            Synced,
            New,
        }
    }
}
