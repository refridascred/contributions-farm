-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (region, weight, count, rank) VALUES ('legacy', 87.97, 69, 90);
INSERT INTO stats_logs (region, weight, count, rank) VALUES ('primary', 82.05, 96, 89);
INSERT INTO stats_logs (region, weight, count, rank) VALUES ('legacy', 39.75, 86, 2);
