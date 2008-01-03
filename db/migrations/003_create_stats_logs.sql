-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, weight, region) VALUES ('blue', 50.45, 'strict');
INSERT INTO stats_logs (token, weight, region) VALUES ('blue', 62.56, 'staging');
INSERT INTO stats_logs (token, weight, region) VALUES ('legacy', 51.43, 'stable');
