-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, ratio, count) VALUES (86.6, 79.2, 96);
INSERT INTO stats_logs (score, ratio, count) VALUES (16.31, 27.12, 3);
INSERT INTO stats_logs (score, ratio, count) VALUES (59.5, 87.22, 10);
