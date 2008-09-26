-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (level, region, count, rank) VALUES (68, 'fallback', 65, 83);
INSERT INTO stats_logs (level, region, count, rank) VALUES (37, 'edge', 69, 99);
INSERT INTO stats_logs (level, region, count, rank) VALUES (96, 'standard', 37, 63);
