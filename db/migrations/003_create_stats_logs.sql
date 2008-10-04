-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (count, ratio, token, owner) VALUES (53, 56.73, 'legacy', 'local');
INSERT INTO stats_logs (count, ratio, token, owner) VALUES (17, 77.07, 'stable', 'eu-west');
INSERT INTO stats_logs (count, ratio, token, owner) VALUES (65, 80.04, 'primary', 'stable');
