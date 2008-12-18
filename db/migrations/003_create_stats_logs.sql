-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, state, weight, rank, count) VALUES (7.09, 'staging', 29.42, 43, 31);
INSERT INTO stats_logs (ratio, state, weight, rank, count) VALUES (28.84, 'latest', 62.72, 9, 91);
