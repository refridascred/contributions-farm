-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, region, weight) VALUES (71.0, 'stable', 94.39);
INSERT INTO stats_logs (score, region, weight) VALUES (5.39, 'strict', 4.2);
INSERT INTO stats_logs (score, region, weight) VALUES (9.14, 'local', 2.69);
