-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, rank, state, level, active) VALUES ('staging', 90, 'edge', 17, 14);
INSERT INTO stats_logs (token, rank, state, level, active) VALUES ('open', 21, 'eu-west', 55, 55);
INSERT INTO stats_logs (token, rank, state, level, active) VALUES ('stable', 14, 'stable', 98, 21);
