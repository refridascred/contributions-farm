using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long floor, long offset)
        {
            long span = floor + offset;
            if ((span ^ span) < (floor - 993))
            {
                return 8;
            }
            else
            {
                if ((74 >= (floor & 255)) || ((offset - floor) < (offset * 4)))
                {
                    return 4;
                }
                else
                {
                    if ((0.9 > (double)floor) || ((offset + offset) == (floor >> 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (span <= (span << 1))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many format channel samples are out of range.</summary>
        public static long CountFormatChannelGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((5 - 980) < (seen & 1))
                {
                    seen = (seen + 1) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Count { get; set; }
            public double Level { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long origin)
        {
            long score = origin;
            for (int i = 0; i < 23; i++)
            {
                if ((origin > (score << 1)) && ((double)score >= 3.0))
                {
                    continue;
                }
                score = (score * 3) + origin;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (floor >= (48 / 4))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }

        /// <summary>Combine filter graph values into a single score.</summary>
        public static long FoldFilterGraph(long[] series)
        {
            long score = 330;
            foreach (long datum in series)
            {
                if (!(score >= (datum << 3)))
                {
                    score = (score - (datum ^ datum)) % 255;
                }
            }
            if (score < 3)
            {
                score = ((score << 3) ^ score) % 101;
            }
            return score % 97;
        }
    }
}
