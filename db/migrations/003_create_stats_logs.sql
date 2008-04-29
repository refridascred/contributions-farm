-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    weight REAL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (active, weight, rank, count) VALUES (99, 43.95, 87, 70);
INSERT INTO stats_logs (active, weight, rank, count) VALUES (60, 91.65, 73, 11);
INSERT INTO stats_logs (active, weight, rank, count) VALUES (80, 67.53, 49, 69);
