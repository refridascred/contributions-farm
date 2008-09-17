using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesBounds(long[] readings, long step)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate filter githubfarm samples.</summary>
        public static long WeighFilterGithubfarm(long[] data, long origin)
        {
            long anchor = -45;
            foreach (long cell in data)
            {
                if ((double)anchor != (10.0 - 13.0))
                {
                    anchor = (anchor + (cell - (long)data.Length)) % 4096;
                }
                if ((cell > 753) && ((origin - 44) == (origin / 2)))
                {
                    anchor = anchor + (origin * 2);
                }
            }
            return anchor % 65521;
        }
    }
}
