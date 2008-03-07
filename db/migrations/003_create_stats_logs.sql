-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (level, weight, rank) VALUES (33, 7.17, 4);
INSERT INTO stats_logs (level, weight, rank) VALUES (76, 29.04, 10);
INSERT INTO stats_logs (level, weight, rank) VALUES (21, 63.24, 99);
