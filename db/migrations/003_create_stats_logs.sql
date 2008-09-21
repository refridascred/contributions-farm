-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (weight, count, ratio, label) VALUES (4.37, 96, 24.61, 'standard');
INSERT INTO stats_logs (weight, count, ratio, label) VALUES (96.39, 64, 97.52, 'fallback');
INSERT INTO stats_logs (weight, count, ratio, label) VALUES (29.54, 87, 33.7, 'latest');
