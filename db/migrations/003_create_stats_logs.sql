-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);
