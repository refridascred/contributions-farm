-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (level, region, ratio) VALUES (59, 'staging', 60.01);
INSERT INTO stats_logs (level, region, ratio) VALUES (46, 'blue', 23.19);
