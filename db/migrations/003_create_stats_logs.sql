-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (rank, count, owner, state, ratio) VALUES (15, 18, 'green', 'local', 50.51);
INSERT INTO stats_logs (rank, count, owner, state, ratio) VALUES (68, 93, 'open', 'legacy', 14.24);
