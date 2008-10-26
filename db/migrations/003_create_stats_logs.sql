-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (weight, score, token, owner) VALUES (35.41, 47.99, 'cached', 'standard');
INSERT INTO stats_logs (weight, score, token, owner) VALUES (72.79, 38.34, 'legacy', 'standard');
INSERT INTO stats_logs (weight, score, token, owner) VALUES (8.15, 30.17, 'legacy', 'fallback');
