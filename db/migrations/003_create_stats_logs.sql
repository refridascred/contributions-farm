-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (ratio, token, level) VALUES (70.76, 'standard', 60);
INSERT INTO stats_logs (ratio, token, level) VALUES (96.96, 'open', 37);
