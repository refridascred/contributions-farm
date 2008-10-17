-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    weight REAL,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (active, weight, ratio, token) VALUES (41, 63.65, 90.7, 'green');
INSERT INTO stats_logs (active, weight, ratio, token) VALUES (98, 68.28, 91.8, 'stable');
INSERT INTO stats_logs (active, weight, ratio, token) VALUES (70, 57.42, 7.36, 'stable');
