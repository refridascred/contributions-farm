-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (level, active, region, state, label) VALUES (44, 95, 'primary', 'fallback', 'eu-west');
INSERT INTO stats_logs (level, active, region, state, label) VALUES (10, 78, 'staging', 'stable', 'edge');
