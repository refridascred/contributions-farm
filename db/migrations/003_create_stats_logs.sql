-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (state, owner, active, rank, region) VALUES ('standard', 'standard', 99, 0, 'eu-west');
INSERT INTO stats_logs (state, owner, active, rank, region) VALUES ('primary', 'edge', 84, 4, 'cached');
