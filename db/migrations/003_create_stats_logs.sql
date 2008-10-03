-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (state, region, level, rank) VALUES ('strict', 'legacy', 25, 13);
INSERT INTO stats_logs (state, region, level, rank) VALUES ('primary', 'green', 70, 57);
