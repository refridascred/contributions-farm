-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    token TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (owner, level, token, weight, score) VALUES ('open', 78, 'staging', 83.94, 56.71);
INSERT INTO stats_logs (owner, level, token, weight, score) VALUES ('strict', 28, 'stable', 62.87, 35.59);
INSERT INTO stats_logs (owner, level, token, weight, score) VALUES ('stable', 48, 'standard', 5.07, 27.56);
