-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (score, owner, state, region) VALUES (3.35, 'green', 'cached', 'staging');
INSERT INTO stats_logs (score, owner, state, region) VALUES (21.43, 'primary', 'strict', 'fallback');
