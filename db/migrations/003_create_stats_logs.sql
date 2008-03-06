-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (region, ratio, active, state, owner) VALUES ('edge', 60.3, 90, 'fallback', 'latest');
INSERT INTO stats_logs (region, ratio, active, state, owner) VALUES ('fallback', 93.22, 9, 'eu-west', 'staging');
INSERT INTO stats_logs (region, ratio, active, state, owner) VALUES ('local', 44.59, 15, 'strict', 'local');
