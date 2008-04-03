-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (level, ratio, active, state, region) VALUES (36, 50.12, 49, 'blue', 'staging');
INSERT INTO stats_logs (level, ratio, active, state, region) VALUES (54, 37.22, 75, 'blue', 'primary');
