-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    region TEXT,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (count, ratio, region, level) VALUES (7, 67.27, 'stable', 52);
INSERT INTO stats_logs (count, ratio, region, level) VALUES (85, 69.47, 'strict', 54);
INSERT INTO stats_logs (count, ratio, region, level) VALUES (18, 80.8, 'latest', 56);
