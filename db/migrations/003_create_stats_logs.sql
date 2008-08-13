-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (region, score, level, owner, rank) VALUES ('stable', 25.14, 81, 'stable', 47);
INSERT INTO stats_logs (region, score, level, owner, rank) VALUES ('eu-west', 36.33, 60, 'blue', 73);
