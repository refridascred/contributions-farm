-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (active, ratio, state) VALUES (40, 98.04, 'legacy');
INSERT INTO stats_logs (active, ratio, state) VALUES (51, 70.86, 'blue');
INSERT INTO stats_logs (active, ratio, state) VALUES (67, 16.85, 'standard');
