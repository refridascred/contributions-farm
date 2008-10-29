-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, weight, label) VALUES (4.64, 17.58, 'fallback');
INSERT INTO stats_logs (score, weight, label) VALUES (5.76, 15.83, 'cached');
INSERT INTO stats_logs (score, weight, label) VALUES (63.79, 20.9, 'green');
