-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, count, region, label) VALUES (3.5, 24, 'latest', 'fallback');
INSERT INTO stats_logs (ratio, count, region, label) VALUES (96.92, 44, 'fallback', 'standard');
