-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (count, token, weight, label) VALUES (97, 'latest', 24.04, 'green');
INSERT INTO stats_logs (count, token, weight, label) VALUES (44, 'fallback', 21.85, 'fallback');
INSERT INTO stats_logs (count, token, weight, label) VALUES (85, 'strict', 21.27, 'latest');
