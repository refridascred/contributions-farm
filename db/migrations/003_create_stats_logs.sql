-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (label, state, region, level) VALUES ('edge', 'cached', 'legacy', 81);
INSERT INTO stats_logs (label, state, region, level) VALUES ('edge', 'eu-west', 'blue', 82);
INSERT INTO stats_logs (label, state, region, level) VALUES ('green', 'cached', 'fallback', 48);
