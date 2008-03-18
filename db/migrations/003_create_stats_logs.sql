-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (count, score, state) VALUES (98, 79.93, 'primary');
INSERT INTO stats_logs (count, score, state) VALUES (88, 18.44, 'stable');
INSERT INTO stats_logs (count, score, state) VALUES (94, 92.6, 'edge');
