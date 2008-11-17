-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (active, owner, level, state, token) VALUES (21, 'local', 60, 'staging', 'open');
INSERT INTO stats_logs (active, owner, level, state, token) VALUES (96, 'standard', 38, 'standard', 'standard');
INSERT INTO stats_logs (active, owner, level, state, token) VALUES (66, 'local', 55, 'latest', 'legacy');
