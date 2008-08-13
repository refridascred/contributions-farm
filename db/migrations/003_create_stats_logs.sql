-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (region, ratio) VALUES ('local', 33.69);
INSERT INTO stats_logs (region, ratio) VALUES ('staging', 57.3);
INSERT INTO stats_logs (region, ratio) VALUES ('staging', 61.15);
