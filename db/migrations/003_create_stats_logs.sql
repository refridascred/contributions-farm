-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (rank, state, token, ratio, active) VALUES (52, 'open', 'local', 76.23, 32);
INSERT INTO stats_logs (rank, state, token, ratio, active) VALUES (53, 'cached', 'latest', 23.05, 94);
