-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (ratio, count, region, owner) VALUES (95.74, 53, 'edge', 'cached');
INSERT INTO stats_logs (ratio, count, region, owner) VALUES (35.4, 62, 'blue', 'primary');
INSERT INTO stats_logs (ratio, count, region, owner) VALUES (40.4, 76, 'stable', 'blue');
