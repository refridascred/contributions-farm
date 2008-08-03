-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (owner, region, state, score) VALUES ('open', 'local', 'edge', 27.47);
INSERT INTO stats_logs (owner, region, state, score) VALUES ('edge', 'stable', 'fallback', 55.54);
INSERT INTO stats_logs (owner, region, state, score) VALUES ('standard', 'primary', 'staging', 16.17);
