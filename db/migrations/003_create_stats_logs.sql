-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (ratio, level, score, owner, active) VALUES (39.62, 69, 1.46, 'primary', 89);
INSERT INTO stats_logs (ratio, level, score, owner, active) VALUES (28.51, 49, 41.0, 'eu-west', 72);
