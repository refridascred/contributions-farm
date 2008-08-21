-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (label, rank, score, level) VALUES ('primary', 87, 78.18, 59);
INSERT INTO stats_logs (label, rank, score, level) VALUES ('stable', 30, 26.59, 36);
INSERT INTO stats_logs (label, rank, score, level) VALUES ('fallback', 11, 3.86, 56);
