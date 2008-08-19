-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (region, rank, weight) VALUES ('strict', 63, 20.33);
INSERT INTO stats_logs (region, rank, weight) VALUES ('open', 18, 9.56);
INSERT INTO stats_logs (region, rank, weight) VALUES ('blue', 5, 57.84);
