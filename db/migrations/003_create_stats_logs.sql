-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, region, level, count) VALUES ('blue', 'cached', 15, 28);
INSERT INTO stats_logs (state, region, level, count) VALUES ('cached', 'staging', 66, 49);
INSERT INTO stats_logs (state, region, level, count) VALUES ('stable', 'fallback', 90, 84);
