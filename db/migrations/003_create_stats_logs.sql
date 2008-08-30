-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (count, score, rank, label) VALUES (97, 57.6, 61, 'legacy');
