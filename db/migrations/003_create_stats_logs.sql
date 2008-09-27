-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (region, state, count, weight) VALUES ('standard', 'legacy', 53, 63.27);
INSERT INTO stats_logs (region, state, count, weight) VALUES ('open', 'strict', 13, 6.55);
INSERT INTO stats_logs (region, state, count, weight) VALUES ('edge', 'legacy', 81, 69.9);
