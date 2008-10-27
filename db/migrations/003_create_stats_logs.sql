-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (active, ratio, label, state) VALUES (80, 74.77, 'green', 'open');
INSERT INTO stats_logs (active, ratio, label, state) VALUES (4, 53.2, 'legacy', 'stable');
INSERT INTO stats_logs (active, ratio, label, state) VALUES (70, 47.13, 'edge', 'legacy');
