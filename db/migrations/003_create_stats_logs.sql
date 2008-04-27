-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    created_at TIMESTAMP,
    level INTEGER,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (rank, level, token, count) VALUES (8, 56, 'stable', 42);
INSERT INTO stats_logs (rank, level, token, count) VALUES (92, 0, 'staging', 6);
INSERT INTO stats_logs (rank, level, token, count) VALUES (75, 29, 'open', 81);
