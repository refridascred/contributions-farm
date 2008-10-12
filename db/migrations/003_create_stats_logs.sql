-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (level, count, region) VALUES (83, 49, 'fallback');
INSERT INTO stats_logs (level, count, region) VALUES (36, 2, 'cached');
INSERT INTO stats_logs (level, count, region) VALUES (8, 70, 'edge');
