-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (count, region, state, active, score) VALUES (61, 'primary', 'green', 10, 73.06);
INSERT INTO stats_logs (count, region, state, active, score) VALUES (15, 'primary', 'stable', 5, 56.12);
INSERT INTO stats_logs (count, region, state, active, score) VALUES (88, 'edge', 'cached', 3, 12.29);
