-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (score, owner, rank, count, level) VALUES (73.65, 'green', 33, 86, 92);
INSERT INTO stats_logs (score, owner, rank, count, level) VALUES (15.93, 'open', 96, 2, 92);
INSERT INTO stats_logs (score, owner, rank, count, level) VALUES (74.0, 'edge', 96, 38, 4);
