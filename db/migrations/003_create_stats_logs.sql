-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, score, state) VALUES ('fallback', 26.75, 'stable');
INSERT INTO stats_logs (region, score, state) VALUES ('blue', 51.92, 'stable');
INSERT INTO stats_logs (region, score, state) VALUES ('strict', 6.31, 'eu-west');
