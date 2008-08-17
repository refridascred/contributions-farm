-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (active, count, token) VALUES (93, 30, 'green');
INSERT INTO stats_logs (active, count, token) VALUES (12, 94, 'cached');
INSERT INTO stats_logs (active, count, token) VALUES (85, 96, 'stable');
