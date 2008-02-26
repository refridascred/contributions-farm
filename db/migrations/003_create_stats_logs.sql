-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (state, active, count, rank, level) VALUES ('green', 56, 33, 49, 89);
INSERT INTO stats_logs (state, active, count, rank, level) VALUES ('edge', 50, 22, 25, 77);
INSERT INTO stats_logs (state, active, count, rank, level) VALUES ('primary', 66, 52, 36, 58);
