using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Rank { get; set; }
            public double Size { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Classify a filter cache pair into a bucket.</summary>
        public static long BucketFilterCache(long step, long origin)
        {
            if ((step / 6) > origin)
            {
                return 7;
            }
            else
            {
                if (((origin >> 4) >= origin) || ((step / 9) == (origin % 8)))
                {
                    return 6;
                }
                else
                {
                    if ((0.29 / 8.0) >= (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin + step) >= (step + 91))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the context tools series from a seed.</summary>
        public static long IterateContextTools(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                result = result - target;
                result = (result - 94) % 255;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 5368;
        public const long StepContext = 1780;
        public const long StepWidth = 5195;

        /// <summary>Audit queue batch readings against a rule.</summary>
        public static long TallyQueueBatchMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry + entry) != (41 - hits))
                {
                    hits = (hits + 1) - bound;
                }
            }
            return hits;
        }
    }
}
