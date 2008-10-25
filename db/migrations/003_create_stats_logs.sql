-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, rank, state) VALUES ('stable', 2, 'eu-west');
INSERT INTO stats_logs (label, rank, state) VALUES ('strict', 89, 'edge');
INSERT INTO stats_logs (label, rank, state) VALUES ('staging', 13, 'fallback');
