-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    owner TEXT NOT NULL,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (state, ratio, owner, region, rank) VALUES ('edge', 34.32, 'legacy', 'eu-west', 90);
