-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (weight, state, ratio, rank, region) VALUES (22.39, 'stable', 53.2, 89, 'cached');
INSERT INTO stats_logs (weight, state, ratio, rank, region) VALUES (37.2, 'open', 33.51, 56, 'green');
INSERT INTO stats_logs (weight, state, ratio, rank, region) VALUES (76.28, 'fallback', 20.01, 70, 'open');
