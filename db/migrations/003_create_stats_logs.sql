-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (label, active, token, rank, count) VALUES ('open', 28, 'fallback', 13, 85);
INSERT INTO stats_logs (label, active, token, rank, count) VALUES ('legacy', 49, 'blue', 90, 7);
