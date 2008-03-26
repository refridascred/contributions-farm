-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (active, state, region, level) VALUES (35, 'legacy', 'strict', 73);
INSERT INTO stats_logs (active, state, region, level) VALUES (78, 'legacy', 'strict', 98);
INSERT INTO stats_logs (active, state, region, level) VALUES (76, 'blue', 'cached', 26);
