-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, owner, token, weight) VALUES (36, 'staging', 'staging', 8.62);
INSERT INTO stats_logs (count, owner, token, weight) VALUES (37, 'eu-west', 'standard', 21.26);
