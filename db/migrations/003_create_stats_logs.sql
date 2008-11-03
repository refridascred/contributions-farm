-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    ratio REAL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (rank, ratio, label, score) VALUES (1, 37.04, 'primary', 56.47);
INSERT INTO stats_logs (rank, ratio, label, score) VALUES (0, 69.42, 'legacy', 45.23);
