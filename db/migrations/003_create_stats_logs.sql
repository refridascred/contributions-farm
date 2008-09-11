-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, level, ratio) VALUES ('latest', 35, 46.41);
INSERT INTO stats_logs (region, level, ratio) VALUES ('fallback', 31, 37.47);
INSERT INTO stats_logs (region, level, ratio) VALUES ('cached', 60, 25.02);
