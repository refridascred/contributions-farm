-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, label) VALUES (28.68, 'latest');
INSERT INTO stats_logs (ratio, label) VALUES (65.76, 'local');
INSERT INTO stats_logs (ratio, label) VALUES (57.3, 'edge');
