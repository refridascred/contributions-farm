-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (rank, region, ratio, state) VALUES (43, 'local', 86.24, 'standard');
INSERT INTO stats_logs (rank, region, ratio, state) VALUES (13, 'fallback', 77.45, 'standard');
