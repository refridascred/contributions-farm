-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (state, active, region, owner) VALUES ('staging', 11, 'latest', 'latest');
INSERT INTO stats_logs (state, active, region, owner) VALUES ('fallback', 98, 'staging', 'eu-west');
INSERT INTO stats_logs (state, active, region, owner) VALUES ('local', 26, 'standard', 'stable');
