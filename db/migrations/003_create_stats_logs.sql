-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (rank, owner, active) VALUES (78, 'edge', 41);
INSERT INTO stats_logs (rank, owner, active) VALUES (27, 'latest', 25);
INSERT INTO stats_logs (rank, owner, active) VALUES (3, 'blue', 36);
