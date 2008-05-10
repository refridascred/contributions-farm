-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (ratio, region, state, score) VALUES (87.42, 'latest', 'green', 92.74);
INSERT INTO stats_logs (ratio, region, state, score) VALUES (48.24, 'standard', 'standard', 38.64);
INSERT INTO stats_logs (ratio, region, state, score) VALUES (74.89, 'standard', 'latest', 97.34);
