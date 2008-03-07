-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, count, level) VALUES (63.44, 44, 79);
INSERT INTO stats_logs (score, count, level) VALUES (3.19, 30, 91);
INSERT INTO stats_logs (score, count, level) VALUES (63.76, 64, 98);
