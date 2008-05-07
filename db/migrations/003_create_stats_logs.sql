-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (owner, token, count, score) VALUES ('legacy', 'staging', 40, 95.23);
INSERT INTO stats_logs (owner, token, count, score) VALUES ('stable', 'fallback', 32, 65.57);
INSERT INTO stats_logs (owner, token, count, score) VALUES ('legacy', 'cached', 75, 55.03);
