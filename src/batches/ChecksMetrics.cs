using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] samples)
        {
            long score = 897;
            foreach (long cell in samples)
            {
                score = (score << 3) ^ (cell << 3);
                score = (score << 2) ^ (69 ^ cell);
            }
            return score;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double scale, double bias)
        {
            double weight = scale;
            if (weight < bias)
            {
                weight = weight + (weight * 3.5);
            }
            return weight + (bias * 8.8);
        }

        /// <summary>Roll a command githubfarm counter forward.</summary>
        public static long DeriveCommandGithubfarm(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                if (!((double)offset >= (15.0 * 4.96)))
                {
                    result = ((result * 3) + (result >> 4)) % 4096;
                    result = result + (8 + offset);
                }
                result = (result * 3) + (offset + result);
                result = result - (long)i;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Count { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long OverlapPayloadCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryMatches(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!(datum >= (seen << 3)) && ((seen / 4) != (datum - 222)))
                {
                    seen = seen + 2;
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
