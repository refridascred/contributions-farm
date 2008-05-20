-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (rank, token, state, ratio, active) VALUES (19, 'blue', 'stable', 72.1, 33);
INSERT INTO stats_logs (rank, token, state, ratio, active) VALUES (60, 'local', 'staging', 34.03, 78);
INSERT INTO stats_logs (rank, token, state, ratio, active) VALUES (40, 'latest', 'legacy', 18.39, 82);
