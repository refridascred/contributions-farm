-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, ratio, state, region, rank) VALUES (91.13, 76.66, 'latest', 'open', 40);
INSERT INTO stats_logs (score, ratio, state, region, rank) VALUES (73.51, 57.63, 'stable', 'legacy', 0);
INSERT INTO stats_logs (score, ratio, state, region, rank) VALUES (55.81, 28.85, 'latest', 'strict', 17);
