-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, count, weight) VALUES ('standard', 44, 47.58);
INSERT INTO stats_logs (region, count, weight) VALUES ('eu-west', 78, 63.27);
INSERT INTO stats_logs (region, count, weight) VALUES ('latest', 2, 72.43);
