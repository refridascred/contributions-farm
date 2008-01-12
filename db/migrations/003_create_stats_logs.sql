-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (ratio, owner, state, active, level) VALUES (13.85, 'fallback', 'staging', 50, 65);
INSERT INTO stats_logs (ratio, owner, state, active, level) VALUES (73.33, 'eu-west', 'stable', 33, 82);
