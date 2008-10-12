-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);
