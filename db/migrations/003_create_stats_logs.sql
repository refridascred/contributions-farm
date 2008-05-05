-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (score, rank, token, active, state) VALUES (8.4, 23, 'cached', 46, 'blue');
INSERT INTO stats_logs (score, rank, token, active, state) VALUES (97.56, 17, 'eu-west', 42, 'local');
INSERT INTO stats_logs (score, rank, token, active, state) VALUES (79.66, 26, 'fallback', 25, 'green');
