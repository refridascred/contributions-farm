-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (active, token, ratio, count, state) VALUES (52, 'local', 67.55, 80, 'local');
INSERT INTO stats_logs (active, token, ratio, count, state) VALUES (97, 'local', 90.66, 51, 'eu-west');
