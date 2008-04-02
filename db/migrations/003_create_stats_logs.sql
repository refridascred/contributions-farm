-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (region, count, owner, weight) VALUES ('green', 56, 'green', 75.21);
INSERT INTO stats_logs (region, count, owner, weight) VALUES ('strict', 57, 'eu-west', 28.76);
INSERT INTO stats_logs (region, count, owner, weight) VALUES ('green', 45, 'latest', 92.23);
