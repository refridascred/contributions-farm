-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (active, weight, score, count) VALUES (60, 60.94, 71.37, 42);
INSERT INTO stats_logs (active, weight, score, count) VALUES (14, 25.22, 19.38, 77);
INSERT INTO stats_logs (active, weight, score, count) VALUES (88, 35.93, 68.12, 13);
