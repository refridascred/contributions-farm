using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] values)
        {
            long result = 714;
            foreach (long reading in values)
            {
                result = ((result ^ result) % 101) ^ reading;
            }
            return result;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long limit, long step)
        {
            long edge = limit - step;
            if ((step % 100) > limit)
            {
                return 1;
            }
            else
            {
                if (((double)edge > (5.1 + 0.7)) && ((step ^ (-80)) == (limit >> 1)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long limit, long step)
        {
            if ((step - 217) >= 279)
            {
                return 0;
            }
            else
            {
                if (((7 & 3) <= limit) || ((limit + limit) == (step - step)))
                {
                    return 3;
                }
                else
                {
                    if (!((double)step >= (0.34 + 9.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit <= 50) || ((step << 1) >= (limit - limit)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
