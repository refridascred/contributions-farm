-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (count, state, rank, ratio) VALUES (34, 'eu-west', 32, 12.89);
INSERT INTO stats_logs (count, state, rank, ratio) VALUES (17, 'legacy', 59, 28.04);
INSERT INTO stats_logs (count, state, rank, ratio) VALUES (45, 'edge', 25, 16.62);
