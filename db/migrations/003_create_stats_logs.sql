-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (token, level, state, region, ratio) VALUES ('standard', 15, 'strict', 'green', 52.8);
INSERT INTO stats_logs (token, level, state, region, ratio) VALUES ('fallback', 91, 'stable', 'latest', 52.4);
INSERT INTO stats_logs (token, level, state, region, ratio) VALUES ('fallback', 2, 'primary', 'green', 74.72);
