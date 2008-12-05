-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    label TEXT,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (active, owner, label, ratio, region) VALUES (99, 'local', 'legacy', 34.01, 'primary');
INSERT INTO stats_logs (active, owner, label, ratio, region) VALUES (52, 'edge', 'legacy', 57.04, 'fallback');
INSERT INTO stats_logs (active, owner, label, ratio, region) VALUES (77, 'edge', 'fallback', 47.76, 'strict');
