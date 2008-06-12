-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    rank INTEGER,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (region, label, rank, score) VALUES ('stable', 'eu-west', 70, 71.25);
INSERT INTO stats_logs (region, label, rank, score) VALUES ('edge', 'local', 30, 80.79);
