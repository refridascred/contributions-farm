-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, region, owner, rank) VALUES (60.63, 'strict', 'legacy', 75);
INSERT INTO stats_logs (score, region, owner, rank) VALUES (43.12, 'stable', 'standard', 46);
INSERT INTO stats_logs (score, region, owner, rank) VALUES (86.74, 'green', 'local', 76);
