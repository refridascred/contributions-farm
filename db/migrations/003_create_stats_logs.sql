-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (weight, score, region, count) VALUES (77.45, 24.6, 'legacy', 36);
INSERT INTO stats_logs (weight, score, region, count) VALUES (91.95, 47.21, 'staging', 51);
INSERT INTO stats_logs (weight, score, region, count) VALUES (67.75, 65.54, 'strict', 14);
