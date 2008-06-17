-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (owner, active, ratio, weight) VALUES ('primary', 89, 18.7, 6.38);
INSERT INTO stats_logs (owner, active, ratio, weight) VALUES ('green', 40, 85.86, 1.74);
INSERT INTO stats_logs (owner, active, ratio, weight) VALUES ('latest', 77, 55.39, 67.13);
