-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (state, rank, count) VALUES ('strict', 64, 27);
INSERT INTO stats_logs (state, rank, count) VALUES ('green', 32, 87);
INSERT INTO stats_logs (state, rank, count) VALUES ('fallback', 64, 45);
