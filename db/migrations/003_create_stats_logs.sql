-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (count, score, level, rank) VALUES (60, 33.95, 64, 82);
INSERT INTO stats_logs (count, score, level, rank) VALUES (98, 81.98, 75, 5);
INSERT INTO stats_logs (count, score, level, rank) VALUES (84, 42.16, 52, 64);
