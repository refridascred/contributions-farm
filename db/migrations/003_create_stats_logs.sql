-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (ratio, score, rank, owner) VALUES (5.81, 30.83, 51, 'edge');
INSERT INTO stats_logs (ratio, score, rank, owner) VALUES (54.8, 48.91, 12, 'eu-west');
INSERT INTO stats_logs (ratio, score, rank, owner) VALUES (74.04, 27.66, 63, 'green');
