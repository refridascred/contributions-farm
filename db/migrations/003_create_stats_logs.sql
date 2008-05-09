-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (token, state, score, rank, owner) VALUES ('legacy', 'green', 79.15, 98, 'staging');
INSERT INTO stats_logs (token, state, score, rank, owner) VALUES ('legacy', 'stable', 37.44, 57, 'staging');
