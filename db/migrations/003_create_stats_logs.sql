-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, state, owner) VALUES (1.83, 'latest', 'strict');
INSERT INTO stats_logs (ratio, state, owner) VALUES (10.94, 'edge', 'standard');
INSERT INTO stats_logs (ratio, state, owner) VALUES (42.45, 'cached', 'blue');
