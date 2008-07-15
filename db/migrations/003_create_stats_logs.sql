-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (count, region, token, state) VALUES (41, 'primary', 'primary', 'fallback');
INSERT INTO stats_logs (count, region, token, state) VALUES (87, 'green', 'green', 'green');
INSERT INTO stats_logs (count, region, token, state) VALUES (90, 'cached', 'local', 'local');
