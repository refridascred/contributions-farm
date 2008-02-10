-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, level, rank, count, label) VALUES ('green', 84, 73, 28, 'stable');
INSERT INTO stats_logs (token, level, rank, count, label) VALUES ('latest', 44, 55, 14, 'staging');
