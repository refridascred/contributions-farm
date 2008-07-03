-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (owner, count, rank, state) VALUES ('primary', 93, 74, 'blue');
INSERT INTO stats_logs (owner, count, rank, state) VALUES ('latest', 15, 95, 'cached');
INSERT INTO stats_logs (owner, count, rank, state) VALUES ('blue', 95, 20, 'staging');
