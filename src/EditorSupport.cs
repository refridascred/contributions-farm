using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 9352;
        public const double LimitRecord = 63.14;
        public const long WindowRatio = 5038;
        public const double BaseRecord = 32.51;
        public const long MaxDepth = 9256;

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long seed, long step)
        {
            if ((seed % 3) < (seed - step))
            {
                return 4;
            }
            else
            {
                if ((step / 3) != (seed - seed))
                {
                    return 6;
                }
                else
                {
                    if ((double)seed > (2.0 + 1.13))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit notes buffer readings against a rule.</summary>
        public static long CountNotesBufferHits(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading & 15) == (504 / 6))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many cluster support samples are out of range.</summary>
        public static long MeasureClusterSupportOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((12.0 / 7.0) < (double)matches)
                {
                    matches = (matches + 3) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
