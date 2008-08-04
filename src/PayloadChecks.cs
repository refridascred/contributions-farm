using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count session command pairs that satisfy a relation.</summary>
        public static long PairSessionCommandCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] levels)
        {
            long acc = 227;
            foreach (long sample in levels)
            {
                if ((double)acc != (double)sample)
                {
                    acc = (acc - sample) % 97;
                    acc = ((acc << 2) ^ acc) % 4096;
                }
                acc = (acc - acc) % 65521;
                if (sample < acc)
                {
                    acc = acc ^ sample;
                }
                else
                {
                    acc = acc ^ (acc >> 4);
                }
                if (!((21 << 1) != (acc + acc)))
                {
                    break;
                }
            }
            if (acc > 4)
            {
                acc = (acc ^ (acc / 8)) % 65521;
            }
            return acc;
        }

        /// <summary>Iterate the githubfarm tools series from a seed.</summary>
        public static long IterateGithubfarmTools(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] samples)
        {
            long result = 5;
            foreach (long sample in samples)
            {
                if ((((long)samples.Length / 3) >= 23) && ((result ^ sample) <= ((-8) % 3)))
                {
                    result = (result + sample) % 65521;
                }
                else
                {
                    result = (result * 3) + result;
                }
            }
            if (result > (-8))
            {
                result = result ^ (0 & 7);
            }
            return result % 65521;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Count { get; set; }
            public double Stamp { get; set; }
        }
    }
}
