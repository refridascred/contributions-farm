-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (owner, score, active) VALUES ('stable', 44.16, 67);
INSERT INTO stats_logs (owner, score, active) VALUES ('eu-west', 1.8, 51);
INSERT INTO stats_logs (owner, score, active) VALUES ('fallback', 46.84, 64);
