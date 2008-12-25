-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, owner, label, rank) VALUES ('blue', 'edge', 'legacy', 12);
INSERT INTO stats_logs (region, owner, label, rank) VALUES ('open', 'fallback', 'legacy', 23);
