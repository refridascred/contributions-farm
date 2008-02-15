-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (active, state, ratio, level, count) VALUES (11, 'latest', 67.76, 84, 56);
INSERT INTO stats_logs (active, state, ratio, level, count) VALUES (40, 'staging', 51.42, 21, 95);
INSERT INTO stats_logs (active, state, ratio, level, count) VALUES (30, 'cached', 13.17, 85, 21);
