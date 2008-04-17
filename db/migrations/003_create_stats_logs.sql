-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (rank, state, weight) VALUES (57, 'eu-west', 20.36);
INSERT INTO stats_logs (rank, state, weight) VALUES (58, 'staging', 95.25);
