-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (state, owner, active, count, region) VALUES ('blue', 'fallback', 60, 28, 'strict');
INSERT INTO stats_logs (state, owner, active, count, region) VALUES ('cached', 'cached', 3, 60, 'legacy');
INSERT INTO stats_logs (state, owner, active, count, region) VALUES ('staging', 'cached', 2, 16, 'stable');
