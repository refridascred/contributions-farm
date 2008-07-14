-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, rank, level) VALUES (32.48, 92, 28);
INSERT INTO stats_logs (weight, rank, level) VALUES (47.02, 31, 79);
INSERT INTO stats_logs (weight, rank, level) VALUES (8.33, 63, 62);
