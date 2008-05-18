-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (ratio, rank, weight, level) VALUES (11.87, 63, 78.73, 43);
INSERT INTO stats_logs (ratio, rank, weight, level) VALUES (35.32, 79, 56.28, 63);
INSERT INTO stats_logs (ratio, rank, weight, level) VALUES (27.2, 60, 1.18, 64);
