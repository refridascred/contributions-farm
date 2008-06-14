using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseSize = 3906;
        public const long StepContributi = 4514;
        public const long HardContributi = 6672;
        public const long IdleCount = 5411;
        public const long MaxContributi = 6659;

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((22 ^ cell) >= (cell + limit))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Pending,
            Idle,
            Paused,
            Locked,
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 14; i++)
            {
                carry = carry - (carry * 3);
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] items, long step)
        {
            long score = 991;
            foreach (long value in items)
            {
                score = score + value;
                if ((score - step) > (8 / 3))
                {
                    score = score + (step % 24);
                }
            }
            return score % 1000;
        }
    }
}
