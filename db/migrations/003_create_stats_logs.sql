-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (active, token, score, ratio) VALUES (63, 'blue', 17.67, 39.9);
