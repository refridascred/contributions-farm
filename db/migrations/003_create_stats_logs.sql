-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (label, ratio, token) VALUES ('latest', 75.73, 'green');
INSERT INTO stats_logs (label, ratio, token) VALUES ('blue', 6.48, 'edge');
INSERT INTO stats_logs (label, ratio, token) VALUES ('eu-west', 13.01, 'legacy');
