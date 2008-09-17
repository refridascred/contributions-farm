-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (weight, active, token) VALUES (53.9, 22, 'strict');
INSERT INTO stats_logs (weight, active, token) VALUES (62.84, 34, 'open');
INSERT INTO stats_logs (weight, active, token) VALUES (43.36, 42, 'legacy');
