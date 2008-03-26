-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (weight, state, rank, ratio, region) VALUES (2.18, 'latest', 43, 27.63, 'staging');
INSERT INTO stats_logs (weight, state, rank, ratio, region) VALUES (39.1, 'green', 96, 47.59, 'local');
INSERT INTO stats_logs (weight, state, rank, ratio, region) VALUES (93.91, 'strict', 6, 21.5, 'stable');
