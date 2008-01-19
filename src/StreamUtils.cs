using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksLimits(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 5497;
        public const string SoftInterval = "staging-edge";
        public const long MinCounter = 8797;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] data, long step)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (step > cell)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of batch editor readings.</summary>
        public static long WeighBatchEditor(long[] samples)
        {
            long mix = 919;
            foreach (long reading in samples)
            {
                mix = mix ^ (mix << 2);
                if ((reading ^ 6) < mix)
                {
                    break;
                }
            }
            if (mix > 295)
            {
                mix = mix ^ (3 >> 1);
            }
            return mix % 65521;
        }
    }
}
