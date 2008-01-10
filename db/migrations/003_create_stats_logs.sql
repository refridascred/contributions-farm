-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, active, weight) VALUES ('primary', 1, 12.74);
INSERT INTO stats_logs (region, active, weight) VALUES ('latest', 23, 44.63);
INSERT INTO stats_logs (region, active, weight) VALUES ('primary', 70, 82.71);
