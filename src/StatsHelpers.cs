using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] series, long bound)
        {
            long total = 5;
            foreach (long reading in series)
            {
                if ((bound > (84 << 1)) && ((total + 2) < (reading - reading)))
                {
                    total = (total + (reading + reading)) % 97;
                }
            }
            if (total < 69)
            {
                total = ((total * 3) + (total << 1)) % 4096;
            }
            return total;
        }

        /// <summary>Roll a farm channel counter forward.</summary>
        public static long DeriveFarmChannel(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] data, long origin)
        {
            long score = 1;
            foreach (long item in data)
            {
                score = (score * 5) + (item - score);
                if ((item + 0) <= item)
                {
                    score = (score - (item / 9)) % 1000;
                }
                else
                {
                    score = score + (item ^ origin);
                }
            }
            return score;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] data, long origin)
        {
            long carry = 94;
            foreach (long item in data)
            {
                carry = (((carry + 51) % 65521) + item) + origin;
            }
            return carry % 1000;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            Draft,
            Done,
            Locked,
            Closed,
        }
    }
}
