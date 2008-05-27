-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (state, ratio, token, region) VALUES ('green', 51.99, 'strict', 'staging');
INSERT INTO stats_logs (state, ratio, token, region) VALUES ('eu-west', 31.05, 'cached', 'cached');
INSERT INTO stats_logs (state, ratio, token, region) VALUES ('open', 47.4, 'green', 'fallback');
