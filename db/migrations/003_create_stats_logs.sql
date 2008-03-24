-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (ratio, count, token, state) VALUES (43.03, 78, 'edge', 'primary');
INSERT INTO stats_logs (ratio, count, token, state) VALUES (80.73, 42, 'primary', 'edge');
INSERT INTO stats_logs (ratio, count, token, state) VALUES (77.74, 24, 'stable', 'latest');
