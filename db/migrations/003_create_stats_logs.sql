-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    weight REAL,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (region, weight, ratio, active) VALUES ('latest', 15.46, 46.62, 62);
INSERT INTO stats_logs (region, weight, ratio, active) VALUES ('cached', 52.86, 9.97, 42);
INSERT INTO stats_logs (region, weight, ratio, active) VALUES ('eu-west', 97.33, 5.91, 23);
