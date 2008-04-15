-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (owner, count, weight, active, token) VALUES ('strict', 96, 75.08, 43, 'fallback');
INSERT INTO stats_logs (owner, count, weight, active, token) VALUES ('latest', 78, 1.21, 70, 'edge');
