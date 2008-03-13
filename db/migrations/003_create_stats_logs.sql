-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (label, token, count) VALUES ('open', 'local', 76);
INSERT INTO stats_logs (label, token, count) VALUES ('green', 'latest', 5);
INSERT INTO stats_logs (label, token, count) VALUES ('primary', 'stable', 98);
