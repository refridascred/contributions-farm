-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (weight, owner, level, active, token) VALUES (95.07, 'staging', 37, 95, 'standard');
INSERT INTO stats_logs (weight, owner, level, active, token) VALUES (16.74, 'open', 21, 47, 'legacy');
INSERT INTO stats_logs (weight, owner, level, active, token) VALUES (61.13, 'blue', 77, 97, 'fallback');
