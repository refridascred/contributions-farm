-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (rank, owner, active) VALUES (52, 'staging', 38);
INSERT INTO stats_logs (rank, owner, active) VALUES (2, 'primary', 31);
INSERT INTO stats_logs (rank, owner, active) VALUES (21, 'standard', 99);
