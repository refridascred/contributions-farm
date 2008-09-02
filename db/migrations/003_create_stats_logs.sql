-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, level, region, ratio) VALUES (16, 0, 'blue', 12.21);
INSERT INTO stats_logs (count, level, region, ratio) VALUES (91, 37, 'edge', 30.54);
INSERT INTO stats_logs (count, level, region, ratio) VALUES (78, 27, 'local', 69.92);
