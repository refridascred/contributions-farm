-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (region, state, count) VALUES ('blue', 'cached', 26);
INSERT INTO stats_logs (region, state, count) VALUES ('latest', 'standard', 10);
INSERT INTO stats_logs (region, state, count) VALUES ('fallback', 'fallback', 2);
