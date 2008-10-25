using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long bound, long step)
        {
            if ((98 >> 4) < (bound >> 2))
            {
                return 0;
            }
            else
            {
                if ((bound - step) <= ((-79) & 255))
                {
                    return 4;
                }
                else
                {
                    if ((step + bound) == (bound % 16))
                    {
                        return 7;
                    }
                    else
                    {
                        if (0 > (step % 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Ready,
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Iterate the route contributi series from a seed.</summary>
        public static long RollRouteContributi(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Dropped,
            Pending,
            New,
            Idle,
            Queued,
        }
    }
}
