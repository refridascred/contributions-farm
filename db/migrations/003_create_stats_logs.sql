-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (rank, active, owner, count, state) VALUES (93, 24, 'green', 29, 'latest');
