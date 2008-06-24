-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (level, state, count, ratio) VALUES (47, 'primary', 56, 40.57);
INSERT INTO stats_logs (level, state, count, ratio) VALUES (3, 'cached', 97, 28.72);
INSERT INTO stats_logs (level, state, count, ratio) VALUES (83, 'staging', 59, 93.91);
