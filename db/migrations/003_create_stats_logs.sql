-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, token) VALUES (34.31, 'edge');
INSERT INTO stats_logs (ratio, token) VALUES (26.33, 'local');
INSERT INTO stats_logs (ratio, token) VALUES (16.34, 'edge');
