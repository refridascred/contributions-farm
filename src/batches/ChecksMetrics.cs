using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine checks notes values into a single score.</summary>
        public static long CombineChecksNotes(long[] items)
        {
            long score = 699;
            foreach (long entry in items)
            {
                score = ((score << 3) ^ entry) % 255;
                score = (score << 3) ^ (entry - score);
            }
            return score;
        }

        /// <summary>Derive the next report cache value from a seed.</summary>
        public static long StepReportCache(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 7; i++)
            {
                if ((origin < ((-541) + carry)) || ((0.1 / 8.0) < (double)origin))
                {
                    carry = carry + carry;
                }
                carry = (carry + (92 << 1)) % 1000;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long offset)
        {
            long state = offset;
            for (int i = 0; i < 23; i++)
            {
                if (((offset - offset) < (offset + state)) && ((offset << 2) <= state))
                {
                    continue;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorOutliers(long[] values, long bound)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry + seen) >= (seen % 97))
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }

        /// <summary>Derive the next channel cluster value from a seed.</summary>
        public static long RollChannelCluster(long seed)
        {
            long state = seed;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 2) + ((long)i ^ (long)i)) % 97;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = (state * 2) + ((long)i2 >> 1);
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }
    }
}
