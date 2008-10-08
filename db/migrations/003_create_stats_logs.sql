-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (level, region, active, score) VALUES (78, 'strict', 63, 54.79);
INSERT INTO stats_logs (level, region, active, score) VALUES (37, 'stable', 24, 62.09);
INSERT INTO stats_logs (level, region, active, score) VALUES (99, 'legacy', 54, 80.3);
