-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (label, rank, state, level) VALUES ('fallback', 35, 'strict', 66);
INSERT INTO stats_logs (label, rank, state, level) VALUES ('latest', 84, 'strict', 20);
