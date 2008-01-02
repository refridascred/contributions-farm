-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, count, label) VALUES (89.93, 38, 'edge');
INSERT INTO stats_logs (score, count, label) VALUES (4.65, 52, 'blue');
INSERT INTO stats_logs (score, count, label) VALUES (76.67, 33, 'primary');
