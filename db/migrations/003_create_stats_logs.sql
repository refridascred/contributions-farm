-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, owner, ratio) VALUES (84.32, 'strict', 26.17);
INSERT INTO stats_logs (score, owner, ratio) VALUES (46.41, 'standard', 75.98);
