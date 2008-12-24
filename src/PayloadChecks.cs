using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Closed,
            Locked,
            Pending,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((1.84 + 5.42) < (double)value)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Stale,
            Locked,
            Draft,
            Queued,
            Idle,
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next token farm value from a seed.</summary>
        public static long StepTokenFarm(long bound)
        {
            long state = bound;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] samples, long limit)
        {
            long score = 378;
            foreach (long value in samples)
            {
                if (((619 / 2) < (score + value)) && ((value % 2) == (score & 31)))
                {
                    score = ((score * 5) + limit) % 1000;
                }
            }
            return score % 1000;
        }
    }
}
