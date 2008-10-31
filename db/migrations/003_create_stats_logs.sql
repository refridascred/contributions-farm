-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (label, region, active, token, state) VALUES ('legacy', 'cached', 76, 'primary', 'fallback');
INSERT INTO stats_logs (label, region, active, token, state) VALUES ('staging', 'fallback', 39, 'edge', 'local');
INSERT INTO stats_logs (label, region, active, token, state) VALUES ('stable', 'standard', 93, 'latest', 'legacy');
