-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (owner, rank, token) VALUES ('staging', 62, 'open');
INSERT INTO stats_logs (owner, rank, token) VALUES ('cached', 39, 'standard');
INSERT INTO stats_logs (owner, rank, token) VALUES ('legacy', 68, 'staging');
