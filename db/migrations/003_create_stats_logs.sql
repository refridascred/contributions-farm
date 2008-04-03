-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (owner, label, region, count) VALUES ('edge', 'edge', 'open', 2);
INSERT INTO stats_logs (owner, label, region, count) VALUES ('primary', 'cached', 'legacy', 39);
INSERT INTO stats_logs (owner, label, region, count) VALUES ('edge', 'local', 'standard', 98);
