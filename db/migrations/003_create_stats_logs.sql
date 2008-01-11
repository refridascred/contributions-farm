-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (rank, state, level, label, owner) VALUES (11, 'strict', 65, 'blue', 'strict');
INSERT INTO stats_logs (rank, state, level, label, owner) VALUES (38, 'strict', 85, 'legacy', 'eu-west');
INSERT INTO stats_logs (rank, state, level, label, owner) VALUES (89, 'local', 59, 'stable', 'cached');
