-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, region, active, rank) VALUES (61, 'local', 7, 51);
INSERT INTO stats_logs (count, region, active, rank) VALUES (9, 'standard', 97, 55);
INSERT INTO stats_logs (count, region, active, rank) VALUES (49, 'eu-west', 87, 46);
