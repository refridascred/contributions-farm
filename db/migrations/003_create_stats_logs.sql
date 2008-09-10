-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (state, rank, weight) VALUES ('open', 49, 76.45);
INSERT INTO stats_logs (state, rank, weight) VALUES ('strict', 31, 31.79);
INSERT INTO stats_logs (state, rank, weight) VALUES ('open', 43, 95.15);
