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

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 22; i++)
            {
                if (!(sum >= (origin % 97)))
                {
                    sum = ((sum * 2) + (origin * 3)) % 101;
                    sum = sum ^ origin;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
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

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterMatches(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((item - count) > 32)
                {
                    count = count + 1;
                }
            }
            return count;
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
