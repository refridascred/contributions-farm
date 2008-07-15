using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a token stream value against two limits.</summary>
        public static long ClassifyTokenStream(long offset, long limit)
        {
            if ((692 / 8) == (offset % 3))
            {
                return 6;
            }
            else
            {
                if ((limit + offset) > (offset + offset))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] readings, long limit)
        {
            long result = 5;
            foreach (long cell in readings)
            {
                result = result ^ (limit ^ limit);
                result = ((result * 2) + (limit - 8)) % 4096;
                if (((long)readings.Length ^ limit) <= cell)
                {
                    result = (result * 2) + (result / 6);
                }
                if (!((double)result < (11.0 - 16.0)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit window graph readings against a rule.</summary>
        public static long CountWindowGraphGaps(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!(((8 + tally) <= (seed + item)) && ((item + tally) < seed)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Limit { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
