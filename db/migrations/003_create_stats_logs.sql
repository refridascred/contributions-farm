-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (token, count, weight, label) VALUES ('edge', 75, 97.07, 'blue');
INSERT INTO stats_logs (token, count, weight, label) VALUES ('cached', 39, 35.62, 'cached');
