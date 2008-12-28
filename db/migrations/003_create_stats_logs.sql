-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    token TEXT,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (weight, region, token, ratio) VALUES (58.12, 'strict', 'local', 74.12);
INSERT INTO stats_logs (weight, region, token, ratio) VALUES (17.17, 'green', 'local', 4.55);
INSERT INTO stats_logs (weight, region, token, ratio) VALUES (64.8, 'cached', 'stable', 28.21);
