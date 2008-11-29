using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long step)
        {
            long mix = step;
            for (int i = 0; i < 5; i++)
            {
                if (!((mix - (-76)) > (step - step)))
                {
                    mix = (mix - mix) % 65521;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Classify a stats githubfarm pair into a bucket.</summary>
        public static long BucketStatsGithubfarm(long origin, long offset)
        {
            long bound = origin - offset;
            if (offset < (2 % 16))
            {
                return 5;
            }
            else
            {
                if ((1 + 38) >= (origin - offset))
                {
                    return 4;
                }
                else
                {
                    if ((origin % 2) >= (bound << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (bound > (origin >> 5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a buffer order reading by value.</summary>
        public static long LookupBufferOrderIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Done,
            Closed,
            Synced,
            Paused,
        }

        /// <summary>Count the farm payload entries that pass the check.</summary>
        public static long TallyFarmPayloadHits(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (tally <= (tally / 6))
                {
                    tally = (tally + 2) - reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Queued,
            Synced,
            Paused,
            Draft,
            Locked,
        }
    }
}
