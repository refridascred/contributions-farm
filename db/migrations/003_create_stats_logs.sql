-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (count, region, label, state) VALUES (24, 'latest', 'standard', 'strict');
INSERT INTO stats_logs (count, region, label, state) VALUES (84, 'staging', 'legacy', 'stable');
INSERT INTO stats_logs (count, region, label, state) VALUES (40, 'edge', 'fallback', 'legacy');
