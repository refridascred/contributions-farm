-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (owner, rank, region, score, weight) VALUES ('fallback', 60, 'open', 94.88, 48.92);
INSERT INTO stats_logs (owner, rank, region, score, weight) VALUES ('blue', 64, 'fallback', 53.54, 21.0);
INSERT INTO stats_logs (owner, rank, region, score, weight) VALUES ('standard', 55, 'stable', 6.51, 27.1);
