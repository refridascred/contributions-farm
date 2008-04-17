-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, rank) VALUES ('local', 84);
INSERT INTO stats_logs (region, rank) VALUES ('blue', 94);
INSERT INTO stats_logs (region, rank) VALUES ('strict', 85);
