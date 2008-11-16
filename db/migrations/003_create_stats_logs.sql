-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (state, score, ratio, rank) VALUES ('strict', 14.32, 10.98, 46);
INSERT INTO stats_logs (state, score, ratio, rank) VALUES ('fallback', 69.73, 52.45, 3);
INSERT INTO stats_logs (state, score, ratio, rank) VALUES ('standard', 22.35, 12.71, 60);
