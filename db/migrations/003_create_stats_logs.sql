-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (weight, rank, ratio, count, state) VALUES (60.23, 59, 39.35, 60, 'primary');
INSERT INTO stats_logs (weight, rank, ratio, count, state) VALUES (20.96, 70, 72.95, 43, 'fallback');
