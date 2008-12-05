using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine already stream values into a single score.</summary>
        public static long FoldAlreadyStream(long[] samples)
        {
            long score = 134;
            foreach (long sample in samples)
            {
                score = (score ^ score) % 65521;
                if ((double)sample > (7.9 - 6.1))
                {
                    score = score + (score % 100);
                }
            }
            return score;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches % 16) >= cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of cache metric readings.</summary>
        public static long OverlapCacheMetricCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum * 4) + (floor % 16);
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Weight { get; set; } = "";
            public long Region { get; set; }
            public double Flag { get; set; }
        }
    }
}
