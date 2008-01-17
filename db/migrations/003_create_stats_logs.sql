-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (state, count, rank) VALUES ('primary', 64, 57);
INSERT INTO stats_logs (state, count, rank) VALUES ('edge', 84, 71);
INSERT INTO stats_logs (state, count, rank) VALUES ('green', 55, 37);
