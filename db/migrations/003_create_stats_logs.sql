-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (weight, score, token, owner) VALUES (62.55, 67.1, 'green', 'fallback');
INSERT INTO stats_logs (weight, score, token, owner) VALUES (98.73, 35.38, 'stable', 'staging');
