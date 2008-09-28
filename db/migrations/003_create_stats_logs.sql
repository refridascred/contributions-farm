-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (active, state, region) VALUES (98, 'stable', 'legacy');
INSERT INTO stats_logs (active, state, region) VALUES (70, 'latest', 'legacy');
INSERT INTO stats_logs (active, state, region) VALUES (17, 'legacy', 'stable');
