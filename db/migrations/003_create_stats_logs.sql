-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, rank) VALUES ('standard', 72);
INSERT INTO stats_logs (region, rank) VALUES ('open', 28);
INSERT INTO stats_logs (region, rank) VALUES ('edge', 78);
