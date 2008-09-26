-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (weight, owner, active, state) VALUES (14.03, 'strict', 49, 'stable');
INSERT INTO stats_logs (weight, owner, active, state) VALUES (82.11, 'fallback', 10, 'legacy');
INSERT INTO stats_logs (weight, owner, active, state) VALUES (15.29, 'local', 39, 'standard');
