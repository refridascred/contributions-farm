-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, level, rank) VALUES (77.97, 59, 59);
INSERT INTO stats_logs (weight, level, rank) VALUES (74.52, 79, 15);
