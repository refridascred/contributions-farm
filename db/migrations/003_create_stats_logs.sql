-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    rank INTEGER,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (state, ratio, rank, token, score) VALUES ('standard', 30.55, 32, 'legacy', 10.83);
INSERT INTO stats_logs (state, ratio, rank, token, score) VALUES ('strict', 53.89, 52, 'stable', 75.05);
