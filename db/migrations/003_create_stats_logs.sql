-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, ratio, score, token, weight) VALUES ('stable', 36.75, 74.5, 'fallback', 48.16);
INSERT INTO stats_logs (owner, ratio, score, token, weight) VALUES ('primary', 92.89, 81.56, 'staging', 64.04);
