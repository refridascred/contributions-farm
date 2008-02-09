-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (owner, active, count) VALUES ('green', 57, 17);
INSERT INTO stats_logs (owner, active, count) VALUES ('local', 96, 30);
INSERT INTO stats_logs (owner, active, count) VALUES ('open', 43, 85);
