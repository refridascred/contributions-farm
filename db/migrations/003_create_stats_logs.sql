-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (count, label, region, score) VALUES (26, 'blue', 'standard', 31.31);
INSERT INTO stats_logs (count, label, region, score) VALUES (85, 'green', 'fallback', 87.54);
INSERT INTO stats_logs (count, label, region, score) VALUES (33, 'edge', 'blue', 82.6);
