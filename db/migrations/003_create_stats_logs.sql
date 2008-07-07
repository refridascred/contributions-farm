-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (state, region, active, weight, ratio) VALUES ('edge', 'stable', 30, 62.88, 97.57);
INSERT INTO stats_logs (state, region, active, weight, ratio) VALUES ('blue', 'stable', 39, 20.09, 91.04);
INSERT INTO stats_logs (state, region, active, weight, ratio) VALUES ('cached', 'legacy', 73, 44.61, 47.1);
