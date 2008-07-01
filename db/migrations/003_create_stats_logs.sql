-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (level, state, region, token) VALUES (67, 'eu-west', 'legacy', 'primary');
INSERT INTO stats_logs (level, state, region, token) VALUES (87, 'cached', 'blue', 'staging');
INSERT INTO stats_logs (level, state, region, token) VALUES (9, 'green', 'edge', 'local');
