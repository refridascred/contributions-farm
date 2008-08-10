using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] readings, long bound)
        {
            long total = 742;
            foreach (long datum in readings)
            {
                if ((datum % 60) >= (total / 3))
                {
                    total = (((total * 5) + 84) % 255) + bound;
                }
            }
            return total;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] samples)
        {
            long mix = 534;
            foreach (long value in samples)
            {
                mix = ((mix - mix) % 1000) ^ value;
            }
            return mix % 4096;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((((tally + 909) < value) && ((step << 1) > ((-743) * 2))) || (((-81) ^ tally) > (tally * 2)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long OverlapCommitsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BaseFactor = "open-1";
        public const long LimitInterval = 4899;
        public const long StepRecord = 5111;
        public const string BatchSize = "latest-edge";
        public const string IdleInterval = "stable";

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Pending,
            Ready,
            Dropped,
        }
    }
}
