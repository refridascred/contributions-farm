-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (rank, count, owner, state) VALUES (80, 48, 'latest', 'legacy');
INSERT INTO stats_logs (rank, count, owner, state) VALUES (91, 30, 'open', 'stable');
INSERT INTO stats_logs (rank, count, owner, state) VALUES (53, 39, 'green', 'edge');
