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

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BaseFactor = "open-1";
        public const long LimitInterval = 4899;
        public const long StepRecord = 5111;
        public const string BatchSize = "latest-edge";
        public const string IdleInterval = "stable";

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((sum + sum) >= (sum + limit))
                {
                    sum = sum - limit;
                }
                else
                {
                    sum = sum + (24 + sum);
                }
                if ((limit + 434) <= (sum >> 3))
                {
                    sum = (sum * 3) + ((-412) ^ sum);
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
