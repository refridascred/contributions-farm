-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (state, score, active, count, rank) VALUES ('green', 96.66, 1, 2, 26);
INSERT INTO stats_logs (state, score, active, count, rank) VALUES ('stable', 94.64, 9, 59, 75);
INSERT INTO stats_logs (state, score, active, count, rank) VALUES ('legacy', 69.05, 75, 52, 83);
