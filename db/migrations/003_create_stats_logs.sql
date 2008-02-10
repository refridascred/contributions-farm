-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (label, state, level, count) VALUES ('stable', 'cached', 82, 22);
INSERT INTO stats_logs (label, state, level, count) VALUES ('open', 'cached', 97, 5);
INSERT INTO stats_logs (label, state, level, count) VALUES ('standard', 'strict', 78, 42);
