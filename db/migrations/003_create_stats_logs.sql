-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, score, region) VALUES (77.99, 28.78, 'eu-west');
INSERT INTO stats_logs (weight, score, region) VALUES (29.49, 98.64, 'legacy');
INSERT INTO stats_logs (weight, score, region) VALUES (78.25, 20.99, 'stable');
