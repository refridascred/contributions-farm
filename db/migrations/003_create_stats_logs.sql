-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (region, state, rank, score) VALUES ('primary', 'blue', 13, 14.7);
INSERT INTO stats_logs (region, state, rank, score) VALUES ('open', 'cached', 1, 27.57);
INSERT INTO stats_logs (region, state, rank, score) VALUES ('blue', 'primary', 92, 21.17);
