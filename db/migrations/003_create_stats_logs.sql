-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (count, region, rank, active, ratio) VALUES (48, 'standard', 74, 48, 44.59);
INSERT INTO stats_logs (count, region, rank, active, ratio) VALUES (59, 'strict', 74, 62, 96.91);
