-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, score, token, region, label) VALUES (6.03, 20.43, 'local', 'latest', 'legacy');
INSERT INTO stats_logs (weight, score, token, region, label) VALUES (82.75, 40.7, 'edge', 'legacy', 'open');
INSERT INTO stats_logs (weight, score, token, region, label) VALUES (37.26, 46.21, 'primary', 'strict', 'eu-west');
