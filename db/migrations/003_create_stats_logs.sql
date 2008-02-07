-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, state, owner, level, region) VALUES (91.14, 'edge', 'latest', 33, 'standard');
INSERT INTO stats_logs (ratio, state, owner, level, region) VALUES (91.83, 'stable', 'latest', 66, 'standard');
INSERT INTO stats_logs (ratio, state, owner, level, region) VALUES (93.94, 'stable', 'open', 41, 'latest');
