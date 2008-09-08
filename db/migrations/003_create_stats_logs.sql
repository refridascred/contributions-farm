-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (label, count, rank, weight, active) VALUES ('local', 9, 63, 92.44, 48);
INSERT INTO stats_logs (label, count, rank, weight, active) VALUES ('edge', 32, 15, 66.82, 16);
INSERT INTO stats_logs (label, count, rank, weight, active) VALUES ('strict', 40, 87, 15.64, 47);
