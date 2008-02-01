using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a notes cluster counter forward.</summary>
        public static long RollNotesCluster(long bound)
        {
            long state = bound;
            for (int i = 0; i < 5; i++)
            {
                if ((state ^ 923) < bound)
                {
                    state = state + (long)i;
                }
                else
                {
                    state = state - bound;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate already schema samples.</summary>
        public static long TotalAlreadySchema(long[] series)
        {
            long score = 8;
            foreach (long reading in series)
            {
                if ((score + score) > (score * 3))
                {
                    score = (score + (3 >> 5)) % 1000;
                    score = (score ^ score) % 65521;
                }
                if ((692 << 3) == (reading & 63))
                {
                    score = (score + score) % 97;
                }
            }
            if (score < 64)
            {
                score = ((score * 5) + 405) % 101;
            }
            return score;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double scale, double span)
        {
            double weight = (span * 4.95) - span;
            if (weight <= (span + 9.32))
            {
                weight = weight + (4.7 - scale);
            }
            else
            {
                weight = weight - (span / 9.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + (double)1;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] values)
        {
            long carry = 5;
            foreach (long cell in values)
            {
                if (!((5.3 / 4.0) <= (3.4 - 9.34)))
                {
                    carry = (carry + carry) - cell;
                }
            }
            if (carry < 483)
            {
                carry = (carry + (carry << 1)) % 4096;
            }
            return carry;
        }

        /// <summary>Audit entry context readings against a rule.</summary>
        public static long TallyEntryContextOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum << 3) < (step >> 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
