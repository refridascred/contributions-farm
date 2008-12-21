-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, active, ratio, rank) VALUES (41.42, 61, 64.57, 29);
INSERT INTO stats_logs (score, active, ratio, rank) VALUES (62.42, 35, 82.45, 48);
