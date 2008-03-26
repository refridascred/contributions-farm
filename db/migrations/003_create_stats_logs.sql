-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (ratio, level, score) VALUES (61.29, 18, 79.7);
