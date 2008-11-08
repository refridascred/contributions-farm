-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (rank, score, state) VALUES (41, 56.78, 'latest');
INSERT INTO stats_logs (rank, score, state) VALUES (84, 23.67, 'blue');
INSERT INTO stats_logs (rank, score, state) VALUES (68, 22.82, 'stable');
