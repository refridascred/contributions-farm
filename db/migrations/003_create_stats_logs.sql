-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (rank, count, score, label, level) VALUES (75, 58, 74.66, 'strict', 5);
INSERT INTO stats_logs (rank, count, score, label, level) VALUES (90, 46, 31.62, 'green', 8);
