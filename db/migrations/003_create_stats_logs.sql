-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (rank, state, region) VALUES (63, 'local', 'strict');
INSERT INTO stats_logs (rank, state, region) VALUES (11, 'strict', 'stable');
INSERT INTO stats_logs (rank, state, region) VALUES (82, 'blue', 'blue');
