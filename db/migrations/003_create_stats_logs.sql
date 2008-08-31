-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, state, owner, label, count) VALUES ('staging', 'strict', 'green', 'edge', 98);
INSERT INTO stats_logs (region, state, owner, label, count) VALUES ('blue', 'green', 'green', 'staging', 46);
