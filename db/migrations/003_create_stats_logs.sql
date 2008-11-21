-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (score, owner, count) VALUES (35.24, 'staging', 17);
INSERT INTO stats_logs (score, owner, count) VALUES (51.71, 'strict', 3);
INSERT INTO stats_logs (score, owner, count) VALUES (79.54, 'open', 46);
