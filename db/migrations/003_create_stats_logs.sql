-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (region, rank, owner, state) VALUES ('eu-west', 39, 'strict', 'eu-west');
INSERT INTO stats_logs (region, rank, owner, state) VALUES ('local', 9, 'legacy', 'stable');
INSERT INTO stats_logs (region, rank, owner, state) VALUES ('standard', 8, 'green', 'latest');
