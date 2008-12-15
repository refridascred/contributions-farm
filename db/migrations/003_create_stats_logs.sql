-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    ratio REAL,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (weight, region, ratio, owner, state) VALUES (76.69, 'cached', 43.34, 'local', 'stable');
INSERT INTO stats_logs (weight, region, ratio, owner, state) VALUES (38.19, 'stable', 53.13, 'blue', 'staging');
INSERT INTO stats_logs (weight, region, ratio, owner, state) VALUES (64.98, 'edge', 16.54, 'cached', 'fallback');
