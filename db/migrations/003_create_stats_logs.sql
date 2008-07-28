-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    label TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (count, label, level, score) VALUES (24, 'standard', 2, 5.79);
INSERT INTO stats_logs (count, label, level, score) VALUES (67, 'eu-west', 40, 74.7);
INSERT INTO stats_logs (count, label, level, score) VALUES (99, 'stable', 12, 40.41);
