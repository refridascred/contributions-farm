-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (region, rank, weight) VALUES ('standard', 93, 67.28);
INSERT INTO stats_logs (region, rank, weight) VALUES ('stable', 82, 69.13);
INSERT INTO stats_logs (region, rank, weight) VALUES ('strict', 30, 81.75);
