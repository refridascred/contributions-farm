-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (level, state, region, label) VALUES (32, 'standard', 'latest', 'local');
INSERT INTO stats_logs (level, state, region, label) VALUES (42, 'latest', 'strict', 'primary');
