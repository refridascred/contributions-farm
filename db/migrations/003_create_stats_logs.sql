-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (level, region, ratio) VALUES (90, 'stable', 33.67);
INSERT INTO stats_logs (level, region, ratio) VALUES (6, 'strict', 98.95);
INSERT INTO stats_logs (level, region, ratio) VALUES (6, 'standard', 80.81);
