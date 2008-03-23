-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, region, state, weight) VALUES ('standard', 'stable', 'strict', 76.22);
INSERT INTO stats_logs (owner, region, state, weight) VALUES ('blue', 'cached', 'edge', 98.12);
INSERT INTO stats_logs (owner, region, state, weight) VALUES ('local', 'stable', 'fallback', 63.48);
