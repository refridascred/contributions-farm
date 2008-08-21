-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    token TEXT,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (active, owner, token, rank, weight) VALUES (38, 'green', 'green', 55, 62.3);
INSERT INTO stats_logs (active, owner, token, rank, weight) VALUES (31, 'fallback', 'latest', 0, 41.4);
