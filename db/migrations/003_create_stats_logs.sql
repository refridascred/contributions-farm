-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (ratio, weight, level, state, rank) VALUES (31.93, 3.96, 73, 'latest', 14);
INSERT INTO stats_logs (ratio, weight, level, state, rank) VALUES (38.22, 46.99, 77, 'strict', 30);
