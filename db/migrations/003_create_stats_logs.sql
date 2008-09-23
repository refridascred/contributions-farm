-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (active, ratio, weight, token) VALUES (32, 42.46, 23.17, 'legacy');
INSERT INTO stats_logs (active, ratio, weight, token) VALUES (29, 33.86, 66.62, 'local');
INSERT INTO stats_logs (active, ratio, weight, token) VALUES (95, 56.91, 33.1, 'latest');
