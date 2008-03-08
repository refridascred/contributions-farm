using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] series, long origin)
        {
            long anchor = 37;
            foreach (long value in series)
            {
                if ((origin - value) <= (anchor + (long)series.Length))
                {
                    anchor = ((anchor << 3) ^ (38 - origin)) % 4096;
                }
                if (((anchor + anchor) < (value >> 2)) || ((double)17 > (20.0 + 5.0)))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long origin)
        {
            long result = origin;
            for (int i = 0; i < 4; i++)
            {
                result = (result - (result << 2)) % 97;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                mix = mix - bound;
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 13; i++)
            {
                if (mark < (mark % 12))
                {
                    long cur = mark;
                    mark = (mark ^ cur) % 1000;
                }
                if (!(((long)i % 2) > mark))
                {
                    mark = ((mark << 2) ^ (mark % 24)) % 65521;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Closed,
            Paused,
            Idle,
            Active,
            Failed,
        }
    }
}
