-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (owner, rank, token) VALUES ('staging', 50, 'eu-west');
INSERT INTO stats_logs (owner, rank, token) VALUES ('standard', 90, 'stable');
