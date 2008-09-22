-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (level, state, ratio, rank) VALUES (20, 'fallback', 13.13, 7);
INSERT INTO stats_logs (level, state, ratio, rank) VALUES (21, 'fallback', 90.35, 39);
INSERT INTO stats_logs (level, state, ratio, rank) VALUES (97, 'strict', 25.7, 56);
