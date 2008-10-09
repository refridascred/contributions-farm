-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (region, weight, active) VALUES ('green', 14.64, 13);
INSERT INTO stats_logs (region, weight, active) VALUES ('latest', 34.25, 96);
INSERT INTO stats_logs (region, weight, active) VALUES ('strict', 34.64, 39);
