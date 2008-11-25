-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, state, region) VALUES (28, 'local', 'edge');
INSERT INTO stats_logs (count, state, region) VALUES (65, 'staging', 'standard');
INSERT INTO stats_logs (count, state, region) VALUES (51, 'legacy', 'eu-west');
