-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, label, rank) VALUES (64.51, 'latest', 68);
INSERT INTO stats_logs (weight, label, rank) VALUES (82.41, 'local', 24);
INSERT INTO stats_logs (weight, label, rank) VALUES (76.92, 'eu-west', 96);
