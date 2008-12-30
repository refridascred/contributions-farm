-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (ratio, owner, rank) VALUES (92.26, 'legacy', 12);
INSERT INTO stats_logs (ratio, owner, rank) VALUES (27.58, 'local', 36);
INSERT INTO stats_logs (ratio, owner, rank) VALUES (53.06, 'strict', 4);
