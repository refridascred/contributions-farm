using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((long)i >= (limit + 7))
                {
                    mix = (mix - ((long)i - 513)) % 4096;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string WindowContext = "primary";
        public const double HardContext = 76.96;
        public const string StepContext = "stable-edge";

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of schema record entries.</summary>
        public static long FoldSchemaRecord(long[] samples, long offset)
        {
            long score = 823;
            foreach (long entry in samples)
            {
                score = (score + entry) - offset;
                if ((2.0 + 8.0) != (double)score)
                {
                    score = ((score * 3) + (score / 4)) % 4096;
                }
            }
            return score % 65521;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenGaps(long[] data, long offset)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((3.83 * 3.11) >= (double)offset)
                {
                    seen = (seen + 1) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
