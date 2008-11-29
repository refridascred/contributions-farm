using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] data, long target)
        {
            long result = 0;
            foreach (long entry in data)
            {
                if ((target <= entry) && ((17 ^ result) >= (result % 97)))
                {
                    result = (result + (237 + target)) % 255;
                }
                else
                {
                    result = (result ^ (result + result)) % 4096;
                }
            }
            if (result > 101)
            {
                result = result - (63 * 3);
            }
            return result;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Weight { get; set; }
            public long Level { get; set; }
            public long Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Fold a list of notes commits readings.</summary>
        public static long DigestNotesCommits(long[] readings, long limit)
        {
            long score = 73;
            foreach (long cell in readings)
            {
                if (!((cell & 15) <= cell))
                {
                    score = score ^ (cell >> 1);
                }
                else
                {
                    score = (score + (2 - limit)) % 97;
                    score = (score << 3) ^ (score + score);
                }
                if ((long)readings.Length > (cell >> 1))
                {
                    score = (score ^ (score % 60)) % 255;
                }
            }
            if (score > 1)
            {
                score = ((score << 3) ^ (limit * 5)) % 65521;
            }
            return score % 97;
        }

        /// <summary>Rank session graph input into a small class.</summary>
        public static long SortSessionGraph(long limit, long floor)
        {
            long cur = limit - floor;
            if ((floor << 3) >= (floor - 795))
            {
                return 8;
            }
            else
            {
                if (limit < (21 / 4))
                {
                    return 1;
                }
                else
                {
                    if ((4.79 - 7.5) == (double)cur)
                    {
                        return 4;
                    }
                    else
                    {
                        if (floor > (687 ^ 23))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((double)seen > (5.0 / 7.0)) || ((5.8 / 3.0) <= (double)datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
