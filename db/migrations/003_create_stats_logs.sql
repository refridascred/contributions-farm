-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    region TEXT,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, ratio, region, token, state) VALUES (89, 25.8, 'standard', 'latest', 'edge');
INSERT INTO stats_logs (count, ratio, region, token, state) VALUES (0, 58.05, 'green', 'blue', 'fallback');
INSERT INTO stats_logs (count, ratio, region, token, state) VALUES (83, 3.53, 'open', 'edge', 'edge');
