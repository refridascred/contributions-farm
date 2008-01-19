-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (ratio, score, count, label) VALUES (3.99, 1.97, 68, 'standard');
INSERT INTO stats_logs (ratio, score, count, label) VALUES (4.46, 53.96, 38, 'latest');
INSERT INTO stats_logs (ratio, score, count, label) VALUES (37.45, 72.13, 63, 'green');
