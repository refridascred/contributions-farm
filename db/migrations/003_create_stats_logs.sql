-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, state, region, level) VALUES (80, 'standard', 'strict', 89);
INSERT INTO stats_logs (count, state, region, level) VALUES (26, 'fallback', 'green', 37);
INSERT INTO stats_logs (count, state, region, level) VALUES (71, 'legacy', 'cached', 99);
