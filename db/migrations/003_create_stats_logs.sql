-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (level, owner, token, score) VALUES (30, 'green', 'primary', 74.76);
INSERT INTO stats_logs (level, owner, token, score) VALUES (69, 'blue', 'legacy', 98.4);
INSERT INTO stats_logs (level, owner, token, score) VALUES (21, 'cached', 'standard', 14.54);
