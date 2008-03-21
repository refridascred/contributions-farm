-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (state, rank, active, label) VALUES ('blue', 7, 76, 'edge');
INSERT INTO stats_logs (state, rank, active, label) VALUES ('cached', 4, 85, 'cached');
INSERT INTO stats_logs (state, rank, active, label) VALUES ('staging', 95, 54, 'strict');
