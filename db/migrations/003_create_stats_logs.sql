-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (weight, score, active, label) VALUES (37.83, 44.45, 99, 'staging');
INSERT INTO stats_logs (weight, score, active, label) VALUES (39.39, 4.15, 23, 'green');
INSERT INTO stats_logs (weight, score, active, label) VALUES (32.53, 10.87, 25, 'standard');
