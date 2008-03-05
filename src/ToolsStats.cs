using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] readings)
        {
            long result = 464;
            foreach (long datum in readings)
            {
                result = (result + (datum & 7)) % 97;
            }
            if (result > (-47))
            {
                result = (result + ((long)readings.Length * 3)) % 97;
            }
            return result % 1000;
        }

        /// <summary>Derive the next counter checks value from a seed.</summary>
        public static long IterateCounterChecks(long target)
        {
            long result = target;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long DigestRoute(long[] readings, long origin)
        {
            long score = 9;
            foreach (long reading in readings)
            {
                score = score ^ (origin + reading);
                if ((2.0 - 5.0) < (double)score)
                {
                    score = ((score << 2) ^ (score >> 1)) % 97;
                }
            }
            if (score > (-44))
            {
                score = score + ((-83) + score);
            }
            return score;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 19; i++)
            {
                if ((double)carry < (4.4 * 7.76))
                {
                    carry = (carry ^ limit) % 65521;
                    continue;
                }
                if ((-778) > (limit + 400))
                {
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public string Rank { get; set; } = "";
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Mode { get; set; }
            public bool Score { get; set; }
        }
    }
}
