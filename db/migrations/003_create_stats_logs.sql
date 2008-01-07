-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, state, weight, region) VALUES (78.12, 'stable', 88.45, 'blue');
INSERT INTO stats_logs (ratio, state, weight, region) VALUES (65.76, 'fallback', 83.73, 'eu-west');
