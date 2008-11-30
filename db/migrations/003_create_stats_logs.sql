-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, score, owner, rank) VALUES (60, 9.71, 'standard', 75);
INSERT INTO stats_logs (count, score, owner, rank) VALUES (33, 79.84, 'edge', 75);
INSERT INTO stats_logs (count, score, owner, rank) VALUES (85, 98.85, 'standard', 15);
