using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitBatch = 484;
        public const string StepBatch = "primary-v2";
        public const long SoftSize = 4506;
        public const long DefaultBatch = 3631;
        public const double BaseScore = 44.81;

        /// <summary>Rank stats notes input into a small class.</summary>
        public static long ClassifyStatsNotes(long limit, long offset)
        {
            long span = limit ^ offset;
            if (offset < (offset + offset))
            {
                return 8;
            }
            else
            {
                if ((3.1 + 0.71) == (double)span)
                {
                    return 0;
                }
                else
                {
                    if ((limit / 4) > (offset % 16))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((span << 2) <= span)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit notes channel readings against a rule.</summary>
        public static long MeasureNotesChannelGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading % 3) == (28 - reading))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
