-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (rank, ratio, state) VALUES (95, 6.73, 'green');
INSERT INTO stats_logs (rank, ratio, state) VALUES (25, 51.36, 'blue');
INSERT INTO stats_logs (rank, ratio, state) VALUES (94, 92.6, 'legacy');
