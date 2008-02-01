-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (score, count, region, state) VALUES (85.04, 41, 'latest', 'cached');
INSERT INTO stats_logs (score, count, region, state) VALUES (68.07, 0, 'standard', 'stable');
INSERT INTO stats_logs (score, count, region, state) VALUES (25.94, 27, 'fallback', 'local');
