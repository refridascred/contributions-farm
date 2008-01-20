-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (level, score, owner, rank) VALUES (47, 94.62, 'stable', 83);
INSERT INTO stats_logs (level, score, owner, rank) VALUES (9, 82.95, 'primary', 50);
