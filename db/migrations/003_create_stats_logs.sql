-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (weight, owner, score, rank) VALUES (96.11, 'latest', 44.66, 3);
INSERT INTO stats_logs (weight, owner, score, rank) VALUES (67.78, 'cached', 58.0, 12);
