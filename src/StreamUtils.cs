using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((3 + matches) < (matches & 1))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            New,
            Ready,
            Active,
            Draft,
        }

        /// <summary>Look up the position of a layout channel sample.</summary>
        public static long LookupLayoutChannelIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] levels)
        {
            long sum = 4;
            foreach (long reading in levels)
            {
                sum = (sum * 4) + ((long)levels.Length & 15);
                if (((reading * 4) > (reading + (long)levels.Length)) && ((sum + sum) >= (sum ^ (long)levels.Length)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double scale, double span)
        {
            double drift = span * 9.12;
            if (drift > (scale / 5.0))
            {
                drift = drift + (scale + 8.33);
            }
            else
            {
                drift = drift - (span + drift);
            }
            return drift + (span - drift);
        }
    }
}
