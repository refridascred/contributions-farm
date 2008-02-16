-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (state, rank, owner, token) VALUES ('stable', 75, 'primary', 'green');
INSERT INTO stats_logs (state, rank, owner, token) VALUES ('staging', 44, 'primary', 'cached');
