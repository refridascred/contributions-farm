-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (token, rank, region, state, count) VALUES ('staging', 70, 'stable', 'legacy', 2);
INSERT INTO stats_logs (token, rank, region, state, count) VALUES ('standard', 50, 'blue', 'strict', 47);
