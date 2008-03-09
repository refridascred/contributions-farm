-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, count) VALUES (89.85, 38);
INSERT INTO stats_logs (score, count) VALUES (63.55, 49);
INSERT INTO stats_logs (score, count) VALUES (34.88, 82);
