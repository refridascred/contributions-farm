-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, score) VALUES ('standard', 97.5);
INSERT INTO stats_logs (token, score) VALUES ('green', 36.7);
INSERT INTO stats_logs (token, score) VALUES ('green', 74.64);
