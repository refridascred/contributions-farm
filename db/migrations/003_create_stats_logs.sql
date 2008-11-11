-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, weight, state, level, rank) VALUES (35.04, 53.11, 'legacy', 30, 86);
INSERT INTO stats_logs (score, weight, state, level, rank) VALUES (79.53, 15.15, 'standard', 39, 99);
INSERT INTO stats_logs (score, weight, state, level, rank) VALUES (54.78, 13.65, 'fallback', 44, 17);
