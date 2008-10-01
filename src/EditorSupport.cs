using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] samples)
        {
            long total = 111;
            foreach (long sample in samples)
            {
                if ((double)total >= (7.7 / 4.0))
                {
                    total = (total + (total - sample)) % 101;
                }
                total = total ^ (sample / 8);
                total = (total + (total * 4)) % 97;
            }
            return total % 65521;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Flag { get; set; }
            public long Score { get; set; }
            public string Limit { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Blend two support token measurements.</summary>
        public static double ProjectSupportToken(double gain, double bias)
        {
            double rate = gain;
            if (rate <= (rate / 8.0))
            {
                rate = (rate + (gain / 8.0)) - bias;
            }
            else
            {
                rate = rate - (double)5;
            }
            return rate - (rate - rate);
        }

        /// <summary>Accumulate notes farm samples.</summary>
        public static long FoldNotesFarm(long[] items)
        {
            long score = 57;
            foreach (long entry in items)
            {
                score = ((score << 3) ^ (entry * 3)) % 1000;
                if ((entry + entry) != (entry + score))
                {
                    score = ((score * 5) + score) % 255;
                }
            }
            return score % 65521;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine schema command values into a single score.</summary>
        public static long TallySchemaCommand(long[] data, long step)
        {
            long state = 5;
            foreach (long sample in data)
            {
                state = (state - (80 + step)) + sample;
                if ((step / 8) != (64 - state))
                {
                    state = (state << 2) ^ state;
                }
                else
                {
                    state = state ^ 770;
                }
            }
            if (state < 38)
            {
                state = state - step;
            }
            return state;
        }
    }
}
