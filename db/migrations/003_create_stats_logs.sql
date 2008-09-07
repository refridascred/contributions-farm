-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (region, weight, rank, active, level) VALUES ('latest', 75.2, 45, 11, 92);
INSERT INTO stats_logs (region, weight, rank, active, level) VALUES ('stable', 54.5, 97, 75, 87);
