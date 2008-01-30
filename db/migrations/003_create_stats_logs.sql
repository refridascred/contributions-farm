-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (rank, count, label, score, level) VALUES (0, 47, 'fallback', 49.56, 96);
INSERT INTO stats_logs (rank, count, label, score, level) VALUES (81, 20, 'blue', 97.38, 12);
INSERT INTO stats_logs (rank, count, label, score, level) VALUES (59, 7, 'green', 28.81, 0);
