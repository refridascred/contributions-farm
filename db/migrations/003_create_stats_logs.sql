-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, count, region) VALUES (71.56, 6, 'strict');
INSERT INTO stats_logs (ratio, count, region) VALUES (44.43, 91, 'local');
INSERT INTO stats_logs (ratio, count, region) VALUES (41.22, 80, 'primary');
