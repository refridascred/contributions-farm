-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (rank, active, score, owner, level) VALUES (63, 93, 52.88, 'staging', 42);
INSERT INTO stats_logs (rank, active, score, owner, level) VALUES (6, 66, 72.98, 'local', 1);
INSERT INTO stats_logs (rank, active, score, owner, level) VALUES (64, 30, 8.86, 'eu-west', 33);
