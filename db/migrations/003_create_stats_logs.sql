-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (score, count, owner, token) VALUES (71.96, 64, 'staging', 'latest');
INSERT INTO stats_logs (score, count, owner, token) VALUES (37.15, 92, 'primary', 'strict');
INSERT INTO stats_logs (score, count, owner, token) VALUES (80.9, 26, 'cached', 'standard');
