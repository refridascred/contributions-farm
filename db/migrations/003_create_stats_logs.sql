-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    weight REAL,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (count, region, weight, owner, level) VALUES (27, 'edge', 63.9, 'fallback', 22);
INSERT INTO stats_logs (count, region, weight, owner, level) VALUES (74, 'staging', 30.6, 'edge', 8);
