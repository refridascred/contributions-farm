-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    ratio REAL,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, token, ratio, level, owner) VALUES (29.2, 'cached', 96.73, 31, 'green');
INSERT INTO stats_logs (weight, token, ratio, level, owner) VALUES (37.61, 'green', 67.32, 90, 'eu-west');
