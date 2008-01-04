-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (level, score, owner, token, rank) VALUES (86, 4.46, 'green', 'staging', 36);
INSERT INTO stats_logs (level, score, owner, token, rank) VALUES (75, 24.92, 'cached', 'green', 1);
INSERT INTO stats_logs (level, score, owner, token, rank) VALUES (55, 6.92, 'strict', 'strict', 44);
