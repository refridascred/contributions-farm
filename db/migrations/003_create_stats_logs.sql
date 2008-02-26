-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (rank, level, weight) VALUES (36, 95, 91.79);
INSERT INTO stats_logs (rank, level, weight) VALUES (60, 87, 75.14);
INSERT INTO stats_logs (rank, level, weight) VALUES (82, 80, 70.92);
