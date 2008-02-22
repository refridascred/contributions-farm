using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] data, long target)
        {
            long mark = -61;
            foreach (long cell in data)
            {
                if (((double)cell > (double)mark) && ((mark + (-55)) <= (28 + (-12))))
                {
                    mark = (mark ^ (target * 5)) % 97;
                }
                if (mark > (0 / 4))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Dropped,
            New,
            Active,
            Draft,
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Ready,
            Idle,
            Queued,
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Ratio { get; set; }
            public double Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 2110;
        public const long MinFactor = 9912;
        public const long MinToken = 105;
    }
}
