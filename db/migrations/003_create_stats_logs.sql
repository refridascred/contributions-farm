-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (active, owner, state, rank, region) VALUES (42, 'legacy', 'edge', 22, 'local');
INSERT INTO stats_logs (active, owner, state, rank, region) VALUES (38, 'green', 'cached', 58, 'staging');
INSERT INTO stats_logs (active, owner, state, rank, region) VALUES (8, 'blue', 'blue', 45, 'primary');
