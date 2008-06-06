-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (region, ratio) VALUES ('edge', 23.49);
INSERT INTO stats_logs (region, ratio) VALUES ('latest', 9.75);
INSERT INTO stats_logs (region, ratio) VALUES ('staging', 10.33);
