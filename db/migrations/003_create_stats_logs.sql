-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (label, count, active, token) VALUES ('green', 11, 28, 'eu-west');
INSERT INTO stats_logs (label, count, active, token) VALUES ('latest', 27, 72, 'blue');
INSERT INTO stats_logs (label, count, active, token) VALUES ('staging', 59, 0, 'edge');
