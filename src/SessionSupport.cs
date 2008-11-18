using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long limit, long target)
        {
            if (target > (limit - target))
            {
                return 5;
            }
            else
            {
                if ((limit ^ limit) <= limit)
                {
                    return 1;
                }
                else
                {
                    if (!(limit > (limit % 97)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (target >= (target + target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Done,
            Paused,
            Queued,
            Dropped,
        }
    }
}
