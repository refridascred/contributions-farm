-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (level, region, ratio) VALUES (83, 'fallback', 83.49);
INSERT INTO stats_logs (level, region, ratio) VALUES (36, 'local', 49.01);
INSERT INTO stats_logs (level, region, ratio) VALUES (6, 'stable', 13.13);
