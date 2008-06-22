-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, state, region) VALUES (69.71, 'staging', 'primary');
INSERT INTO stats_logs (score, state, region) VALUES (73.82, 'standard', 'standard');
INSERT INTO stats_logs (score, state, region) VALUES (52.4, 'latest', 'fallback');
