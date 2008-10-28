-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (owner, score, rank) VALUES ('latest', 97.55, 33);
INSERT INTO stats_logs (owner, score, rank) VALUES ('stable', 20.51, 49);
INSERT INTO stats_logs (owner, score, rank) VALUES ('edge', 93.29, 23);
