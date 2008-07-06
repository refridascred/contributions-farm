-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (region, weight, level, rank) VALUES ('edge', 60.33, 53, 64);
INSERT INTO stats_logs (region, weight, level, rank) VALUES ('edge', 10.5, 50, 56);
