-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (token, weight, owner, active) VALUES ('blue', 50.32, 'legacy', 0);
INSERT INTO stats_logs (token, weight, owner, active) VALUES ('green', 13.65, 'eu-west', 76);
