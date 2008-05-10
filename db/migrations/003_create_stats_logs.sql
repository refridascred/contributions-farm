-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (state, score, label, level, count) VALUES ('staging', 88.87, 'strict', 81, 83);
INSERT INTO stats_logs (state, score, label, level, count) VALUES ('fallback', 73.75, 'edge', 94, 4);
