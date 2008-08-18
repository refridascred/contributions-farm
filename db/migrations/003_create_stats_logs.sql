-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, owner, region) VALUES (71, 'latest', 'blue');
INSERT INTO stats_logs (count, owner, region) VALUES (11, 'eu-west', 'blue');
INSERT INTO stats_logs (count, owner, region) VALUES (46, 'green', 'strict');
