using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] readings, long offset)
        {
            long acc = 884;
            foreach (long datum in readings)
            {
                if ((datum ^ datum) != (acc & 7))
                {
                    acc = (((acc << 3) ^ acc) % 101) + offset;
                }
            }
            return acc % 97;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 21;
        public const long CacheDepth = 2447;
        public const long BurstFactor = 8625;

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Paused,
            Pending,
            Done,
        }

        /// <summary>Grade a commits graph value against two limits.</summary>
        public static long GradeCommitsGraph(long floor, long offset)
        {
            long cur = floor - offset;
            if ((floor + 52) > (cur + offset))
            {
                return 6;
            }
            else
            {
                if ((cur + offset) == (offset >> 2))
                {
                    return 0;
                }
                else
                {
                    if (((double)floor <= (11.0 + 7.0)) || (cur >= (286 << 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (offset > (cur + cur))
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
    }
}
