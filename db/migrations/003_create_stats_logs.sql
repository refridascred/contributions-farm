-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (region, ratio, level) VALUES ('green', 45.73, 66);
INSERT INTO stats_logs (region, ratio, level) VALUES ('legacy', 64.22, 83);
INSERT INTO stats_logs (region, ratio, level) VALUES ('blue', 2.12, 14);
