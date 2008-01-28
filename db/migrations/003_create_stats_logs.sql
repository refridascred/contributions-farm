-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (token, state, active, owner) VALUES ('standard', 'latest', 6, 'primary');
INSERT INTO stats_logs (token, state, active, owner) VALUES ('cached', 'standard', 54, 'eu-west');
INSERT INTO stats_logs (token, state, active, owner) VALUES ('local', 'local', 39, 'open');
