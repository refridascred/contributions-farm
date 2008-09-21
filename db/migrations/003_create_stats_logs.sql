-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    rank INTEGER,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (ratio, token, rank, region, state) VALUES (28.24, 'standard', 12, 'standard', 'stable');
INSERT INTO stats_logs (ratio, token, rank, region, state) VALUES (43.87, 'latest', 21, 'stable', 'open');
INSERT INTO stats_logs (ratio, token, rank, region, state) VALUES (69.42, 'staging', 65, 'eu-west', 'fallback');
