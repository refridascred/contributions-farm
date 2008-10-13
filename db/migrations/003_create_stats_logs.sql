-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (level, count, label, state, weight) VALUES (5, 62, 'fallback', 'edge', 65.86);
INSERT INTO stats_logs (level, count, label, state, weight) VALUES (5, 27, 'cached', 'standard', 97.04);
