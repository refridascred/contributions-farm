-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, active, rank, label) VALUES (7.13, 91, 67, 'standard');
INSERT INTO stats_logs (weight, active, rank, label) VALUES (23.66, 71, 54, 'edge');
INSERT INTO stats_logs (weight, active, rank, label) VALUES (0.32, 30, 21, 'edge');
