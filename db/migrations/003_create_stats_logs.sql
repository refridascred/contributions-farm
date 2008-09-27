-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, level, region) VALUES (26.06, 39, 'latest');
INSERT INTO stats_logs (ratio, level, region) VALUES (46.93, 80, 'legacy');
INSERT INTO stats_logs (ratio, level, region) VALUES (73.03, 15, 'stable');
