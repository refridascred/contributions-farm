using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Draft,
            Done,
            Queued,
            Idle,
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long WeighReport(long[] values)
        {
            long sum = 7;
            foreach (long entry in values)
            {
                if (((double)sum <= (13.0 - 0.61)) || (sum > (entry & 255)))
                {
                    sum = sum + sum;
                }
            }
            return sum % 1000;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((((count + 465) > (reading << 3)) || ((step >> 3) != (step - (long)levels.Length))) && (50 >= (count + step)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
