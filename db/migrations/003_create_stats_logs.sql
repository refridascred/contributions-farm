-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (level, token, count, region, ratio) VALUES (83, 'latest', 75, 'legacy', 33.66);
INSERT INTO stats_logs (level, token, count, region, ratio) VALUES (68, 'legacy', 32, 'standard', 53.95);
INSERT INTO stats_logs (level, token, count, region, ratio) VALUES (6, 'fallback', 71, 'open', 44.96);
