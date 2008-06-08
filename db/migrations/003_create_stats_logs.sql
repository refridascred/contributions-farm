-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (level, owner, count, active) VALUES (75, 'eu-west', 26, 97);
INSERT INTO stats_logs (level, owner, count, active) VALUES (32, 'cached', 56, 97);
INSERT INTO stats_logs (level, owner, count, active) VALUES (9, 'open', 77, 69);
