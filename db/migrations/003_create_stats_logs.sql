-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (owner, weight, count, rank) VALUES ('primary', 15.29, 72, 15);
INSERT INTO stats_logs (owner, weight, count, rank) VALUES ('staging', 59.51, 74, 2);
INSERT INTO stats_logs (owner, weight, count, rank) VALUES ('blue', 81.98, 47, 40);
