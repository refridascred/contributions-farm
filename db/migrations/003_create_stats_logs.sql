-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, owner, token) VALUES (11.6, 'stable', 'blue');
INSERT INTO stats_logs (ratio, owner, token) VALUES (7.24, 'edge', 'latest');
