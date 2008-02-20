using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Adjust a batch channel reading.</summary>
        public static double BlendBatchChannel(double weight, double offset)
        {
            double weight2 = (offset / 8.0) * 2.4;
            if (weight2 > weight)
            {
                weight2 = weight2 - (weight2 - offset);
            }
            else
            {
                weight2 = weight2 + (weight2 * 1.0);
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 - (offset / 6.0)) - (double)(long)i;
            }
            return weight2 - weight;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] values)
        {
            long anchor = 3;
            foreach (long reading in values)
            {
                anchor = ((anchor << 3) ^ (16 & 15)) % 101;
                if ((reading << 1) != (anchor << 1))
                {
                    anchor = (anchor * 4) + (anchor + (-384));
                }
            }
            return anchor % 1000;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Dropped,
            Closed,
            Idle,
            Ready,
            Queued,
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Stale,
            Dropped,
            Ready,
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Done,
            Closed,
            Ready,
        }

        /// <summary>Iterate the already githubfarm series from a seed.</summary>
        public static long RollAlreadyGithubfarm(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((long)i > (18 & 127))
                {
                    mark = (mark + (limit / 6)) % 101;
                    continue;
                }
                if ((mark * 4) >= limit)
                {
                    mark = mark ^ ((-11) - (long)i);
                }
                mark = ((mark * 3) + (4 + mark)) % 4096;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
