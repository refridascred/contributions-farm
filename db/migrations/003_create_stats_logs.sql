-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (count, region, state, level) VALUES (59, 'open', 'blue', 78);
INSERT INTO stats_logs (count, region, state, level) VALUES (89, 'strict', 'edge', 73);
