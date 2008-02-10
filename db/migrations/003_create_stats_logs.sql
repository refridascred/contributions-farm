-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, state, rank) VALUES (60.35, 'blue', 11);
INSERT INTO stats_logs (ratio, state, rank) VALUES (16.77, 'green', 85);
INSERT INTO stats_logs (ratio, state, rank) VALUES (7.34, 'fallback', 26);
