-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (state, region, rank, count) VALUES ('primary', 'eu-west', 34, 39);
INSERT INTO stats_logs (state, region, rank, count) VALUES ('latest', 'strict', 49, 85);
INSERT INTO stats_logs (state, region, rank, count) VALUES ('strict', 'fallback', 17, 65);
