-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (level, count, owner, score) VALUES (57, 36, 'standard', 32.63);
INSERT INTO stats_logs (level, count, owner, score) VALUES (17, 36, 'eu-west', 78.05);
INSERT INTO stats_logs (level, count, owner, score) VALUES (99, 95, 'legacy', 83.57);
