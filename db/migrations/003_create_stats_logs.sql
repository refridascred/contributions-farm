-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, active, owner, region, state) VALUES ('edge', 16, 'standard', 'open', 'cached');
INSERT INTO stats_logs (label, active, owner, region, state) VALUES ('primary', 4, 'fallback', 'strict', 'staging');
INSERT INTO stats_logs (label, active, owner, region, state) VALUES ('fallback', 91, 'stable', 'fallback', 'blue');
