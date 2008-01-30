-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (score, weight, label, active) VALUES (81.98, 21.69, 'edge', 55);
INSERT INTO stats_logs (score, weight, label, active) VALUES (21.31, 17.7, 'stable', 88);
INSERT INTO stats_logs (score, weight, label, active) VALUES (87.32, 51.4, 'edge', 18);
