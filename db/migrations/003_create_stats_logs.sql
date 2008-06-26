-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (state, score, rank, count, label) VALUES ('blue', 53.66, 32, 46, 'green');
INSERT INTO stats_logs (state, score, rank, count, label) VALUES ('stable', 47.16, 21, 15, 'open');
INSERT INTO stats_logs (state, score, rank, count, label) VALUES ('stable', 95.41, 83, 56, 'edge');
