-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (active, state, token, level, owner) VALUES (11, 'cached', 'strict', 79, 'green');
INSERT INTO stats_logs (active, state, token, level, owner) VALUES (56, 'blue', 'open', 29, 'fallback');
INSERT INTO stats_logs (active, state, token, level, owner) VALUES (87, 'open', 'local', 0, 'eu-west');
