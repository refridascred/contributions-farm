-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    rank INTEGER,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (level, label, rank, state) VALUES (61, 'staging', 26, 'legacy');
INSERT INTO stats_logs (level, label, rank, state) VALUES (60, 'strict', 1, 'edge');
INSERT INTO stats_logs (level, label, rank, state) VALUES (44, 'open', 11, 'local');
