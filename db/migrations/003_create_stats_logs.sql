-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, score, weight, active) VALUES ('cached', 44.38, 23.6, 46);
