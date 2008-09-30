-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (count, token, weight) VALUES (19, 'latest', 71.87);
INSERT INTO stats_logs (count, token, weight) VALUES (55, 'stable', 68.08);
