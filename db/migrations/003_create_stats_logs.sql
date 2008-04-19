-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (level, score, count, label, weight) VALUES (57, 10.77, 75, 'green', 26.16);
INSERT INTO stats_logs (level, score, count, label, weight) VALUES (51, 52.61, 28, 'latest', 68.96);
