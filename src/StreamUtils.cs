using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of commits editor readings.</summary>
        public static long DigestCommitsEditor(long[] levels)
        {
            long score = 508;
            foreach (long value in levels)
            {
                score = (((score * 4) + (score ^ score)) % 97) - value;
            }
            if (score > 7)
            {
                score = (score * 5) + score;
            }
            return score;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Active,
            New,
            Dropped,
            Failed,
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double gain, double span)
        {
            double drift = (gain * 3.0) + gain;
            if (drift <= (double)(-5))
            {
                drift = drift + (span * 16.0);
            }
            else
            {
                drift = drift + (span / 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (drift * 9.1)) + (double)(long)i;
            }
            return drift - (gain / 3.0);
        }

        /// <summary>Validate record buffer readings against a bound.</summary>
        public static bool ValidateRecordBufferRange(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowProfile = "staging-v2";
        public const long DefaultProfile = 3981;
        public const long StepProfile = 2043;
        public const long MinSize = 2758;

        /// <summary>Classify a batches report pair into a bucket.</summary>
        public static long ClassifyBatchesReport(long step, long floor)
        {
            if ((39 + floor) == (floor ^ step))
            {
                return 7;
            }
            else
            {
                if ((13.0 - 11.0) >= (double)floor)
                {
                    return 3;
                }
                else
                {
                    if ((step <= (29 >> 2)) && (step <= ((-369) ^ step)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
