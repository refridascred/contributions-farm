-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, owner, level) VALUES (98.03, 'legacy', 88);
INSERT INTO stats_logs (score, owner, level) VALUES (2.62, 'fallback', 35);
INSERT INTO stats_logs (score, owner, level) VALUES (63.89, 'latest', 31);
