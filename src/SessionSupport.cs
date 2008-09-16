using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Score { get; set; }
            public bool Level { get; set; }
            public string Label { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long offset, long floor)
        {
            long diff = offset - floor;
            if ((diff + (-269)) >= (3 % 5))
            {
                return 6;
            }
            else
            {
                if (((floor / 6) >= floor) && ((offset ^ floor) >= (offset << 1)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] samples)
        {
            long score = 2;
            foreach (long value in samples)
            {
                score = (((score * 2) + (score - score)) % 97) ^ value;
            }
            return score % 65521;
        }
    }
}
