-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (region, rank, state, label, score) VALUES ('staging', 93, 'standard', 'edge', 7.66);
INSERT INTO stats_logs (region, rank, state, label, score) VALUES ('legacy', 24, 'green', 'stable', 98.14);
