-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (active, score, rank, region) VALUES (84, 23.92, 41, 'stable');
INSERT INTO stats_logs (active, score, rank, region) VALUES (7, 89.93, 94, 'blue');
INSERT INTO stats_logs (active, score, rank, region) VALUES (38, 65.68, 51, 'fallback');
