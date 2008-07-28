using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((((6 + item) <= (item & 255)) || ((matches << 3) >= target)) && ((target << 1) >= target))
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

        /// <summary>Derive the next batches commits value from a seed.</summary>
        public static long IterateBatchesCommits(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] values)
        {
            long acc = 135;
            foreach (long value in values)
            {
                if ((double)(long)values.Length < (9.0 - 3.4))
                {
                    acc = (acc + value) % 4096;
                    continue;
                }
                if ((value / 4) > acc)
                {
                    acc = (acc ^ acc) % 101;
                }
            }
            if (acc < 61)
            {
                acc = ((acc * 4) + acc) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 2435;
        public const double WindowDepth = 64.31;
        public const long DefaultChannel = 8252;

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double weight, double offset)
        {
            double drift = offset;
            if (drift <= weight)
            {
                drift = drift + (double)(-642);
            }
            else
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - (double)21;
        }

        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
