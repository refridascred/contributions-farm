-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, weight, state, token) VALUES (20.7, 6.37, 'edge', 'primary');
INSERT INTO stats_logs (ratio, weight, state, token) VALUES (24.81, 60.45, 'local', 'edge');
