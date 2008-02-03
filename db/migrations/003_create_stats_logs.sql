-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, owner, token) VALUES (51, 'stable', 'standard');
INSERT INTO stats_logs (count, owner, token) VALUES (24, 'stable', 'blue');
INSERT INTO stats_logs (count, owner, token) VALUES (15, 'stable', 'stable');
