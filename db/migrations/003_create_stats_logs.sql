-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, level, region, token) VALUES ('open', 79, 'staging', 'legacy');
INSERT INTO stats_logs (state, level, region, token) VALUES ('strict', 37, 'latest', 'fallback');
