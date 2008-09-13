-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    rank INTEGER,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (level, owner, rank, state) VALUES (0, 'open', 49, 'stable');
INSERT INTO stats_logs (level, owner, rank, state) VALUES (98, 'strict', 93, 'strict');
