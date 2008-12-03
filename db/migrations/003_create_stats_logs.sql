-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, score, ratio, owner, label) VALUES (6.01, 69.93, 83.02, 'fallback', 'standard');
INSERT INTO stats_logs (weight, score, ratio, owner, label) VALUES (47.91, 46.75, 59.53, 'latest', 'blue');
INSERT INTO stats_logs (weight, score, ratio, owner, label) VALUES (20.04, 74.43, 25.55, 'legacy', 'edge');
