-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (state, count, rank) VALUES ('legacy', 42, 49);
INSERT INTO stats_logs (state, count, rank) VALUES ('stable', 83, 69);
INSERT INTO stats_logs (state, count, rank) VALUES ('cached', 96, 47);
