-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, count, weight, label) VALUES (7.17, 79, 8.6, 'primary');
INSERT INTO stats_logs (ratio, count, weight, label) VALUES (43.59, 11, 33.27, 'edge');
INSERT INTO stats_logs (ratio, count, weight, label) VALUES (93.47, 18, 82.39, 'stable');
