using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] data)
        {
            long mix = 694;
            foreach (long item in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    mix = (mix ^ ((long)i + mix)) % 4096;
                    mix = mix ^ item;
                }
                if (mix <= (item + item))
                {
                    mix = (mix << 2) ^ (mix - item);
                }
            }
            if (mix > 72)
            {
                mix = (mix - (mix / 6)) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!((double)value != (double)62))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Pending,
            Draft,
            Paused,
        }
    }
}
