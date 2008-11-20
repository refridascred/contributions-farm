-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (rank, ratio, label, count, level) VALUES (25, 53.57, 'edge', 95, 76);
INSERT INTO stats_logs (rank, ratio, label, count, level) VALUES (87, 26.29, 'stable', 13, 37);
INSERT INTO stats_logs (rank, ratio, label, count, level) VALUES (15, 0.79, 'cached', 50, 54);
