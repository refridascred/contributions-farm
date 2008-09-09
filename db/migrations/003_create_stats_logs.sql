-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (active, owner, label, region) VALUES (70, 'cached', 'strict', 'strict');
INSERT INTO stats_logs (active, owner, label, region) VALUES (23, 'fallback', 'legacy', 'local');
INSERT INTO stats_logs (active, owner, label, region) VALUES (34, 'legacy', 'edge', 'cached');
