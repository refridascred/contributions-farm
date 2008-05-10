-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (score, level, region, count) VALUES (56.51, 92, 'cached', 9);
INSERT INTO stats_logs (score, level, region, count) VALUES (64.47, 25, 'edge', 60);
INSERT INTO stats_logs (score, level, region, count) VALUES (83.6, 7, 'legacy', 2);
