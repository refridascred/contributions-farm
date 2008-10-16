-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (level, weight, state, ratio) VALUES (90, 81.81, 'local', 2.14);
INSERT INTO stats_logs (level, weight, state, ratio) VALUES (6, 89.31, 'legacy', 88.92);
