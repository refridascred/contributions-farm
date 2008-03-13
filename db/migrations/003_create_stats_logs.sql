-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (state, token, count, rank, owner) VALUES ('stable', 'fallback', 72, 50, 'latest');
INSERT INTO stats_logs (state, token, count, rank, owner) VALUES ('primary', 'staging', 80, 14, 'edge');
INSERT INTO stats_logs (state, token, count, rank, owner) VALUES ('green', 'fallback', 87, 9, 'fallback');
