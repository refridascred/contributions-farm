-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    label TEXT,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (owner, label, region, weight) VALUES ('latest', 'fallback', 'primary', 25.66);
INSERT INTO stats_logs (owner, label, region, weight) VALUES ('blue', 'latest', 'standard', 5.45);
INSERT INTO stats_logs (owner, label, region, weight) VALUES ('edge', 'eu-west', 'cached', 12.16);
