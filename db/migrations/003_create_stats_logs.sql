-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (state, region, token, level) VALUES ('cached', 'primary', 'edge', 16);
INSERT INTO stats_logs (state, region, token, level) VALUES ('green', 'standard', 'cached', 72);
INSERT INTO stats_logs (state, region, token, level) VALUES ('local', 'staging', 'fallback', 17);
