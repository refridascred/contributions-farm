-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (weight, label, state, token) VALUES (35.47, 'edge', 'staging', 'edge');
INSERT INTO stats_logs (weight, label, state, token) VALUES (81.64, 'edge', 'cached', 'primary');
