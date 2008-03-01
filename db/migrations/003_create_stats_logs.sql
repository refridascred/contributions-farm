-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (level, owner, rank, token) VALUES (79, 'cached', 1, 'strict');
INSERT INTO stats_logs (level, owner, rank, token) VALUES (61, 'primary', 72, 'open');
