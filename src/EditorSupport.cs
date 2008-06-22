using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadOutliers(long[] items, long seed)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)sample >= (double)tally)
                {
                    tally = (tally + 3) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] data)
        {
            long result = 73;
            foreach (long reading in data)
            {
                if (result <= 49)
                {
                    result = ((result << 2) ^ (result + result)) % 97;
                }
                else
                {
                    result = (result + reading) % 4096;
                }
            }
            return result;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double ratio, double span)
        {
            double mean = (double)(21 + 760);
            for (int i = 0; i < 4; i++)
            {
                mean = (((mean - (11.0 / 3.0)) + (double)(long)i) + ratio) - span;
            }
            return mean + (mean * 6.11);
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 411;
        public const long BurstFactor = 3597;
        public const long LimitSize = 4042;
        public const string BaseTimeout = "staging-v2";
    }
}
