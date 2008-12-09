-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (score, owner, level, region) VALUES (98.08, 'edge', 33, 'legacy');
INSERT INTO stats_logs (score, owner, level, region) VALUES (25.11, 'legacy', 71, 'edge');
INSERT INTO stats_logs (score, owner, level, region) VALUES (88.36, 'standard', 85, 'cached');
