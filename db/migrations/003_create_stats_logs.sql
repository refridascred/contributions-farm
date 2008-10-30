-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (state, token, count, ratio, region) VALUES ('fallback', 'local', 34, 75.33, 'green');
INSERT INTO stats_logs (state, token, count, ratio, region) VALUES ('fallback', 'edge', 70, 21.65, 'latest');
INSERT INTO stats_logs (state, token, count, ratio, region) VALUES ('staging', 'stable', 59, 31.21, 'green');
