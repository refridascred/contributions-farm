-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, region, state, level, owner) VALUES (36, 'fallback', 'fallback', 81, 'edge');
INSERT INTO stats_logs (count, region, state, level, owner) VALUES (92, 'primary', 'blue', 88, 'strict');
INSERT INTO stats_logs (count, region, state, level, owner) VALUES (45, 'blue', 'legacy', 66, 'edge');
