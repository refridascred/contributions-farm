-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (rank, region, state) VALUES (2, 'cached', 'fallback');
INSERT INTO stats_logs (rank, region, state) VALUES (17, 'strict', 'standard');
INSERT INTO stats_logs (rank, region, state) VALUES (93, 'standard', 'green');
