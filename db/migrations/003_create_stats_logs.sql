-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (label, count, score, rank) VALUES ('edge', 84, 53.98, 13);
INSERT INTO stats_logs (label, count, score, rank) VALUES ('staging', 43, 79.26, 15);
INSERT INTO stats_logs (label, count, score, rank) VALUES ('open', 55, 65.29, 58);
