-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, level, region) VALUES (26.41, 12, 'strict');
INSERT INTO stats_logs (ratio, level, region) VALUES (55.29, 80, 'cached');
INSERT INTO stats_logs (ratio, level, region) VALUES (28.17, 13, 'local');
