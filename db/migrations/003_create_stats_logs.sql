-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, owner, token) VALUES (25, 'latest', 'green');
INSERT INTO stats_logs (count, owner, token) VALUES (69, 'local', 'primary');
INSERT INTO stats_logs (count, owner, token) VALUES (31, 'stable', 'eu-west');
