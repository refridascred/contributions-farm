-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (weight, rank, ratio, level) VALUES (14.67, 6, 85.97, 42);
