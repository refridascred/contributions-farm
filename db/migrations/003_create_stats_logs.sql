-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (level, state, region) VALUES (26, 'local', 'edge');
INSERT INTO stats_logs (level, state, region) VALUES (83, 'open', 'stable');
INSERT INTO stats_logs (level, state, region) VALUES (3, 'green', 'cached');
