-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, label, token, owner) VALUES (66, 'local', 'fallback', 'latest');
INSERT INTO stats_logs (count, label, token, owner) VALUES (99, 'legacy', 'standard', 'open');
