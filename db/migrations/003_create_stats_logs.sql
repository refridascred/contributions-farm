-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (level, token, score) VALUES (33, 'staging', 80.69);
INSERT INTO stats_logs (level, token, score) VALUES (71, 'standard', 41.12);
INSERT INTO stats_logs (level, token, score) VALUES (89, 'legacy', 41.07);
