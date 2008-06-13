-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (label, weight, score) VALUES ('local', 77.77, 88.44);
INSERT INTO stats_logs (label, weight, score) VALUES ('staging', 71.66, 25.8);
INSERT INTO stats_logs (label, weight, score) VALUES ('standard', 20.29, 55.25);
