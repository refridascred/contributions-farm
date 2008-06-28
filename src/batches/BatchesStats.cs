using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit checks stats readings against a rule.</summary>
        public static long CountChecksStatsGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((((sample + sample) == (origin - seen)) && ((origin >> 2) <= 1)) && ((double)sample < (4.0 + 6.2)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Match up contributi batches samples.</summary>
        public static long MatchContributiBatchesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] samples)
        {
            long state = 73;
            foreach (long value in samples)
            {
                state = state - (state ^ state);
                state = (state + value) % 255;
                if (state > (state * 5))
                {
                    state = (state << 3) ^ state;
                }
                if ((double)(long)samples.Length <= (3.4 / 8.0))
                {
                    break;
                }
            }
            if (state > 784)
            {
                state = (state - (46 + state)) % 1000;
            }
            return state;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TallyTools(long[] levels)
        {
            long carry = 69;
            foreach (long reading in levels)
            {
                carry = (carry ^ (reading >> 3)) % 97;
                for (int i = 0; i < 3; i++)
                {
                    carry = (((carry * 5) + (reading << 3)) % 255) + (long)i;
                }
                if ((carry << 1) >= carry)
                {
                    carry = (carry + (reading - reading)) % 101;
                }
            }
            if (carry > (-74))
            {
                carry = ((carry * 3) + carry) % 101;
            }
            return carry;
        }
    }
}
