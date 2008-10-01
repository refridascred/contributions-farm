-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (region, active, rank, weight, label) VALUES ('local', 62, 85, 91.04, 'cached');
INSERT INTO stats_logs (region, active, rank, weight, label) VALUES ('legacy', 46, 72, 13.02, 'fallback');
INSERT INTO stats_logs (region, active, rank, weight, label) VALUES ('edge', 77, 79, 41.09, 'edge');
