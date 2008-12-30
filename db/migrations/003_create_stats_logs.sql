-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (ratio, token, weight) VALUES (15.54, 'stable', 58.7);
INSERT INTO stats_logs (ratio, token, weight) VALUES (89.49, 'local', 29.1);
