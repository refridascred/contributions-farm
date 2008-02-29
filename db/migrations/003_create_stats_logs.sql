-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (ratio, token, active) VALUES (28.25, 'local', 10);
INSERT INTO stats_logs (ratio, token, active) VALUES (72.29, 'primary', 18);
INSERT INTO stats_logs (ratio, token, active) VALUES (98.98, 'blue', 42);
