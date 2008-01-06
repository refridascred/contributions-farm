-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    created_at TIMESTAMP,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (rank, region, weight, state) VALUES (3, 'open', 48.89, 'local');
