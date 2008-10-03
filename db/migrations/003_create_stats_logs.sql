-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (token, region, state, owner) VALUES ('fallback', 'fallback', 'stable', 'blue');
INSERT INTO stats_logs (token, region, state, owner) VALUES ('strict', 'open', 'fallback', 'strict');
