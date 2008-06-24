-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, rank, state, ratio, region) VALUES (43, 12, 'standard', 65.53, 'green');
INSERT INTO stats_logs (count, rank, state, ratio, region) VALUES (56, 99, 'cached', 74.05, 'legacy');
