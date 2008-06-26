-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (token, owner, state, active) VALUES ('edge', 'eu-west', 'stable', 90);
INSERT INTO stats_logs (token, owner, state, active) VALUES ('local', 'stable', 'stable', 36);
INSERT INTO stats_logs (token, owner, state, active) VALUES ('latest', 'blue', 'fallback', 37);
