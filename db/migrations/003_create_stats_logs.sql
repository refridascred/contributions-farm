-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    created_at TIMESTAMP,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);
