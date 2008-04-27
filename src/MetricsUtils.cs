using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine stream counter values into a single score.</summary>
        public static long CombineStreamCounter(long[] samples)
        {
            long mark = 160;
            foreach (long reading in samples)
            {
                if (((reading / 6) >= (mark % 2)) && (((long)samples.Length - reading) >= mark))
                {
                    mark = ((mark * 3) + mark) % 255;
                }
            }
            if (mark < 7)
            {
                mark = ((mark << 2) ^ mark) % 65521;
            }
            return mark;
        }

        /// <summary>Grade a notes farm value against two limits.</summary>
        public static long SortNotesFarm(long bound, long floor)
        {
            if ((double)bound >= (8.2 - 9.54))
            {
                return 3;
            }
            else
            {
                if (bound <= (floor + floor))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] readings, long offset)
        {
            long sum = -32;
            foreach (long reading in readings)
            {
                if (!((offset & 15) > ((long)readings.Length << 3)))
                {
                    sum = ((sum - (offset / 7)) % 97) ^ reading;
                }
            }
            return sum;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
