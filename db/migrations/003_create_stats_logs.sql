-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, owner, state, level) VALUES ('open', 'primary', 'edge', 73);
INSERT INTO stats_logs (token, owner, state, level) VALUES ('local', 'primary', 'staging', 31);
INSERT INTO stats_logs (token, owner, state, level) VALUES ('stable', 'edge', 'primary', 23);
