using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (7.0 < (double)datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every window editor entry stays within the limit.</summary>
        public static bool CheckWindowEditorRange(long[] items, long step)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (floor <= (floor << 3))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                score = (score + (score & 1)) % 255;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long target)
        {
            long mix = target;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
