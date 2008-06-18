-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (level, label, region, active, state) VALUES (14, 'open', 'strict', 11, 'staging');
INSERT INTO stats_logs (level, label, region, active, state) VALUES (48, 'fallback', 'open', 21, 'eu-west');
