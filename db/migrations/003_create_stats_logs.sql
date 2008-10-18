-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (owner, score, ratio) VALUES ('stable', 45.8, 29.39);
INSERT INTO stats_logs (owner, score, ratio) VALUES ('fallback', 91.13, 15.02);
INSERT INTO stats_logs (owner, score, ratio) VALUES ('strict', 92.97, 57.57);
