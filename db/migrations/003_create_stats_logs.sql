-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (ratio, owner, rank, state, region) VALUES (68.2, 'blue', 94, 'edge', 'blue');
INSERT INTO stats_logs (ratio, owner, rank, state, region) VALUES (52.07, 'cached', 79, 'primary', 'primary');
INSERT INTO stats_logs (ratio, owner, rank, state, region) VALUES (59.7, 'eu-west', 67, 'cached', 'cached');
