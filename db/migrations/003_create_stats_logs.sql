-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (level, state, owner, region, ratio) VALUES (24, 'staging', 'cached', 'edge', 25.17);
INSERT INTO stats_logs (level, state, owner, region, ratio) VALUES (97, 'legacy', 'local', 'fallback', 55.86);
INSERT INTO stats_logs (level, state, owner, region, ratio) VALUES (52, 'standard', 'cached', 'staging', 66.85);
