-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (ratio, count, label, state, region) VALUES (21.43, 96, 'strict', 'standard', 'standard');
INSERT INTO stats_logs (ratio, count, label, state, region) VALUES (19.56, 86, 'green', 'blue', 'strict');
INSERT INTO stats_logs (ratio, count, label, state, region) VALUES (70.47, 15, 'green', 'stable', 'standard');
