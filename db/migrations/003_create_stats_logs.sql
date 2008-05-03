-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (rank, state, region, weight) VALUES (28, 'edge', 'edge', 60.89);
INSERT INTO stats_logs (rank, state, region, weight) VALUES (19, 'cached', 'green', 60.06);
