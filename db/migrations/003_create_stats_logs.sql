-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    level INTEGER,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (state, owner, level, rank, label) VALUES ('blue', 'standard', 25, 36, 'fallback');
INSERT INTO stats_logs (state, owner, level, rank, label) VALUES ('blue', 'fallback', 98, 58, 'fallback');
