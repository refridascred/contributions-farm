-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (region, weight, level) VALUES ('open', 41.96, 92);
INSERT INTO stats_logs (region, weight, level) VALUES ('local', 4.95, 76);
INSERT INTO stats_logs (region, weight, level) VALUES ('green', 31.95, 46);
