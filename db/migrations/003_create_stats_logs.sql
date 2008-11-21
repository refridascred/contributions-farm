-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (region, rank, owner, score) VALUES ('primary', 81, 'edge', 0.3);
INSERT INTO stats_logs (region, rank, owner, score) VALUES ('open', 39, 'green', 85.62);
