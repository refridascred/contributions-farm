-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (region, state, ratio, token) VALUES ('edge', 'blue', 71.32, 'blue');
INSERT INTO stats_logs (region, state, ratio, token) VALUES ('green', 'latest', 76.94, 'local');
INSERT INTO stats_logs (region, state, ratio, token) VALUES ('legacy', 'stable', 60.75, 'stable');
