-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, token, owner) VALUES (98, 'strict', 'cached');
INSERT INTO stats_logs (count, token, owner) VALUES (16, 'strict', 'stable');
INSERT INTO stats_logs (count, token, owner) VALUES (86, 'open', 'blue');
