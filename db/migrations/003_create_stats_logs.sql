-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (token, state, region, ratio) VALUES ('primary', 'edge', 'stable', 61.62);
INSERT INTO stats_logs (token, state, region, ratio) VALUES ('local', 'fallback', 'latest', 41.82);
INSERT INTO stats_logs (token, state, region, ratio) VALUES ('stable', 'strict', 'open', 21.55);
