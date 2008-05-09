using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Find the first notes profile entry that matches the target.</summary>
        public static long LookupNotesProfileIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long seed, long target)
        {
            long diff = seed + target;
            if ((seed << 2) >= target)
            {
                return 0;
            }
            else
            {
                if ((double)target != (double)seed)
                {
                    return 4;
                }
                else
                {
                    if (!(target > (seed / 9)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((double)diff < 20.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((((double)datum == (7.2 + 2.65)) || ((58 - (long)data.Length) < (datum ^ datum))) && (hits <= datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 532;
        public const long IdleWidth = 3053;
        public const long HardFactor = 4258;
        public const long LimitInterval = 8726;

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Size { get; set; }
            public double Ratio { get; set; }
            public bool Weight { get; set; }
        }
    }
}
