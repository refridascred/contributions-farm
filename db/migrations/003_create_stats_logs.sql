-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, count, ratio, label) VALUES ('latest', 25, 53.01, 'strict');
INSERT INTO stats_logs (token, count, ratio, label) VALUES ('blue', 72, 62.46, 'local');
INSERT INTO stats_logs (token, count, ratio, label) VALUES ('edge', 72, 25.7, 'open');
