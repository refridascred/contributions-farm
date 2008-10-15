using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long floor)
        {
            long score = floor;
            for (int i = 0; i < 15; i++)
            {
                long delta = (score >> 2) * 5;
                if (floor >= (delta + score))
                {
                    delta = delta ^ score;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Grade a record buffer value against two limits.</summary>
        public static long GradeRecordBuffer(long target, long bound)
        {
            long edge = target - bound;
            if ((double)edge >= (8.75 * 4.0))
            {
                return 3;
            }
            else
            {
                if (((4.0 + 4.0) != (double)edge) && ((edge & 7) >= (edge + (-440))))
                {
                    return 5;
                }
                else
                {
                    if ((edge ^ 2) < (bound + target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Mode { get; set; }
            public string Label { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
