-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    ratio REAL,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (label, level, ratio, region, token) VALUES ('open', 39, 49.39, 'edge', 'strict');
INSERT INTO stats_logs (label, level, ratio, region, token) VALUES ('stable', 86, 65.73, 'stable', 'local');
