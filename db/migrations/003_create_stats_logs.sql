-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (active, rank, token, score, owner) VALUES (52, 38, 'blue', 84.08, 'stable');
INSERT INTO stats_logs (active, rank, token, score, owner) VALUES (80, 49, 'stable', 84.52, 'standard');
INSERT INTO stats_logs (active, rank, token, score, owner) VALUES (77, 25, 'local', 17.92, 'standard');
