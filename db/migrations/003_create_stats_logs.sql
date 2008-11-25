-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (level, weight, score, label) VALUES (18, 95.79, 9.68, 'latest');
INSERT INTO stats_logs (level, weight, score, label) VALUES (25, 6.38, 96.0, 'green');
INSERT INTO stats_logs (level, weight, score, label) VALUES (6, 81.03, 38.16, 'blue');
