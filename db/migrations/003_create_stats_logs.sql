-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    token TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (owner, rank, token, level, score) VALUES ('blue', 59, 'latest', 81, 13.75);
INSERT INTO stats_logs (owner, rank, token, level, score) VALUES ('open', 96, 'standard', 8, 29.52);
