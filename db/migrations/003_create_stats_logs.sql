-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (region, active, count, weight) VALUES ('latest', 87, 28, 5.18);
INSERT INTO stats_logs (region, active, count, weight) VALUES ('primary', 71, 26, 86.67);
INSERT INTO stats_logs (region, active, count, weight) VALUES ('green', 85, 3, 49.43);
