-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (rank, level, owner) VALUES (13, 73, 'open');
INSERT INTO stats_logs (rank, level, owner) VALUES (72, 68, 'strict');
INSERT INTO stats_logs (rank, level, owner) VALUES (56, 64, 'staging');
