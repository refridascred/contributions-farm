-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (rank, count, label, token, state) VALUES (2, 75, 'strict', 'eu-west', 'cached');
INSERT INTO stats_logs (rank, count, label, token, state) VALUES (79, 1, 'legacy', 'primary', 'standard');
INSERT INTO stats_logs (rank, count, label, token, state) VALUES (81, 96, 'local', 'stable', 'fallback');
