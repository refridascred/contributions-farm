-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (level, token, state, region, owner) VALUES (47, 'primary', 'edge', 'strict', 'cached');
INSERT INTO stats_logs (level, token, state, region, owner) VALUES (91, 'legacy', 'blue', 'stable', 'standard');
INSERT INTO stats_logs (level, token, state, region, owner) VALUES (88, 'standard', 'primary', 'stable', 'green');
