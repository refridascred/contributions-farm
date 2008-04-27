-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (label, weight, token) VALUES ('standard', 58.77, 'strict');
INSERT INTO stats_logs (label, weight, token) VALUES ('blue', 18.65, 'stable');
INSERT INTO stats_logs (label, weight, token) VALUES ('edge', 59.66, 'primary');
