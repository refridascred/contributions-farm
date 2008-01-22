-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (rank, count, owner, token) VALUES (55, 97, 'green', 'eu-west');
INSERT INTO stats_logs (rank, count, owner, token) VALUES (46, 87, 'fallback', 'standard');
