-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, state, level, rank) VALUES (79.84, 'legacy', 91, 73);
INSERT INTO stats_logs (ratio, state, level, rank) VALUES (54.7, 'stable', 90, 98);
