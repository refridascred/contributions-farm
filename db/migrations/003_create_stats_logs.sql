-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (ratio, token, active) VALUES (75.11, 'cached', 86);
INSERT INTO stats_logs (ratio, token, active) VALUES (80.66, 'blue', 38);
INSERT INTO stats_logs (ratio, token, active) VALUES (42.43, 'eu-west', 67);
