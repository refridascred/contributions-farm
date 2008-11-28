-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (rank, state, ratio, count) VALUES (76, 'fallback', 15.04, 95);
INSERT INTO stats_logs (rank, state, ratio, count) VALUES (8, 'legacy', 52.07, 63);
INSERT INTO stats_logs (rank, state, ratio, count) VALUES (43, 'fallback', 10.2, 55);
