-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (score, token, count, active) VALUES (12.61, 'staging', 49, 16);
INSERT INTO stats_logs (score, token, count, active) VALUES (58.1, 'green', 44, 11);
INSERT INTO stats_logs (score, token, count, active) VALUES (31.0, 'eu-west', 44, 52);
