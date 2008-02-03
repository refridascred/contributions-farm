-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, count, score, ratio) VALUES ('local', 57, 30.17, 36.11);
INSERT INTO stats_logs (owner, count, score, ratio) VALUES ('fallback', 94, 39.31, 0.66);
INSERT INTO stats_logs (owner, count, score, ratio) VALUES ('staging', 24, 78.39, 85.46);
