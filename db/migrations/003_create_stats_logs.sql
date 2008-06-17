-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (owner, level, rank) VALUES ('blue', 61, 29);
INSERT INTO stats_logs (owner, level, rank) VALUES ('staging', 33, 75);
INSERT INTO stats_logs (owner, level, rank) VALUES ('green', 90, 54);
