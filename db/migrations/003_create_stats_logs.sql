-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (label, weight, rank) VALUES ('fallback', 24.51, 80);
INSERT INTO stats_logs (label, weight, rank) VALUES ('local', 34.88, 63);
INSERT INTO stats_logs (label, weight, rank) VALUES ('strict', 74.13, 59);
