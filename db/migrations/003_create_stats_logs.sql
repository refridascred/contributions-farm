-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, count, token) VALUES (13.51, 19, 'edge');
INSERT INTO stats_logs (ratio, count, token) VALUES (89.01, 29, 'blue');
INSERT INTO stats_logs (ratio, count, token) VALUES (52.52, 12, 'open');
