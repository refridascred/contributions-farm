-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    ratio REAL,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (state, region, ratio, owner, rank) VALUES ('standard', 'latest', 69.51, 'strict', 66);
INSERT INTO stats_logs (state, region, ratio, owner, rank) VALUES ('edge', 'edge', 50.73, 'edge', 28);
