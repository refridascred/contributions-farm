-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);
