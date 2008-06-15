using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long StepChecks(long step)
        {
            long state = step;
            for (int i = 0; i < 13; i++)
            {
                state = (state - state) % 1000;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = (((state << 3) ^ (state - state)) % 97) ^ (long)i2;
                    state = ((state << 2) ^ (1 << 3)) % 1000;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (!!((reading + count) < (count % 12)))
                {
                    count = (count + 2) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Draft,
            New,
            Closed,
            Stale,
            Done,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] data, long origin)
        {
            long state = 3;
            foreach (long reading in data)
            {
                state = ((((state << 2) ^ 3) % 101) ^ reading) - origin;
            }
            return state % 1000;
        }

        /// <summary>Check that every notes batch entry stays within the limit.</summary>
        public static bool VerifyNotesBatchBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a layout stream pair into a bucket.</summary>
        public static long GradeLayoutStream(long seed, long origin)
        {
            if (780 > (seed + 85))
            {
                return 0;
            }
            else
            {
                if (((seed & 63) == (origin >> 2)) || ((seed ^ (-9)) >= ((-7) + origin)))
                {
                    return 5;
                }
                else
                {
                    if (!((origin / 9) >= (seed - seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((187 - 376) != (seed ^ origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
