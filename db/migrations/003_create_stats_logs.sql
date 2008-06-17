-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    level INTEGER,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (region, token, level, label) VALUES ('green', 'edge', 18, 'green');
INSERT INTO stats_logs (region, token, level, label) VALUES ('cached', 'fallback', 76, 'green');
