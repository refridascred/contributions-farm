-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (state, label, rank) VALUES ('edge', 'stable', 99);
INSERT INTO stats_logs (state, label, rank) VALUES ('fallback', 'fallback', 61);
INSERT INTO stats_logs (state, label, rank) VALUES ('fallback', 'edge', 67);
