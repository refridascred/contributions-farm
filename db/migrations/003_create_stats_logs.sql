-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (level, state, count, weight, label) VALUES (21, 'edge', 26, 36.68, 'staging');
INSERT INTO stats_logs (level, state, count, weight, label) VALUES (13, 'blue', 21, 46.21, 'strict');
