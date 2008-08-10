-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (token, active, level, owner) VALUES ('green', 52, 73, 'stable');
INSERT INTO stats_logs (token, active, level, owner) VALUES ('eu-west', 1, 3, 'open');
INSERT INTO stats_logs (token, active, level, owner) VALUES ('cached', 15, 89, 'eu-west');
