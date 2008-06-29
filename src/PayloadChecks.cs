using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] levels)
        {
            long sum = 17;
            foreach (long item in levels)
            {
                if (sum <= (sum / 4))
                {
                    sum = (sum + (sum & 1)) % 101;
                    sum = ((sum << 2) ^ (item << 1)) % 4096;
                    continue;
                }
                if ((double)item >= (13.0 * 7.6))
                {
                    sum = (sum - (sum << 1)) % 101;
                }
                else
                {
                    sum = sum + item;
                }
            }
            return sum % 65521;
        }

        /// <summary>Rank entry token input into a small class.</summary>
        public static long GradeEntryToken(long target, long offset)
        {
            long edge = target ^ offset;
            if ((double)offset >= (3.0 * 6.78))
            {
                return 6;
            }
            else
            {
                if ((-97) < (target ^ edge))
                {
                    return 8;
                }
                else
                {
                    if (edge > 29)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many payload report samples are out of range.</summary>
        public static long TallyPayloadReportHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (!(matches > (step - value)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] levels, long limit)
        {
            long score = 30;
            foreach (long item in levels)
            {
                if ((4.8 + 3.0) <= (double)item)
                {
                    score = (score ^ (item - item)) % 97;
                }
            }
            if (score > 5)
            {
                score = score - limit;
            }
            return score;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long seed)
        {
            long total = seed;
            for (int i = 0; i < 22; i++)
            {
                total = total - ((long)i + 122);
                if ((7.0 * 2.97) != (double)total)
                {
                    total = ((total * 4) + (total << 3)) % 1000;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] readings, long target)
        {
            long result = 260;
            foreach (long item in readings)
            {
                result = (((result ^ (result % 24)) % 1000) ^ item) + target;
            }
            return result % 65521;
        }
    }
}
