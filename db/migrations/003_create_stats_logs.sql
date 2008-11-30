-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, state, rank, active) VALUES ('green', 'cached', 26, 52);
INSERT INTO stats_logs (token, state, rank, active) VALUES ('stable', 'legacy', 86, 54);
INSERT INTO stats_logs (token, state, rank, active) VALUES ('legacy', 'local', 75, 38);
