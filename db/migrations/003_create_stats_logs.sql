-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, level, rank) VALUES (11.95, 18, 36);
INSERT INTO stats_logs (weight, level, rank) VALUES (94.07, 3, 38);
INSERT INTO stats_logs (weight, level, rank) VALUES (87.9, 59, 47);
