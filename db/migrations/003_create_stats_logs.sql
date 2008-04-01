-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (region, state, count, ratio) VALUES ('primary', 'cached', 54, 33.0);
INSERT INTO stats_logs (region, state, count, ratio) VALUES ('green', 'stable', 23, 7.76);
INSERT INTO stats_logs (region, state, count, ratio) VALUES ('edge', 'edge', 48, 56.2);
