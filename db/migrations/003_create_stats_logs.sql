-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (level, rank, state) VALUES (84, 28, 'fallback');
INSERT INTO stats_logs (level, rank, state) VALUES (39, 79, 'blue');
INSERT INTO stats_logs (level, rank, state) VALUES (30, 32, 'green');
