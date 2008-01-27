-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (ratio, level, token) VALUES (41.53, 12, 'standard');
INSERT INTO stats_logs (ratio, level, token) VALUES (20.41, 78, 'latest');
INSERT INTO stats_logs (ratio, level, token) VALUES (7.65, 55, 'edge');
