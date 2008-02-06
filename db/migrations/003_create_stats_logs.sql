-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    created_at TIMESTAMP,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, level, label, score) VALUES ('edge', 9, 'stable', 85.55);
INSERT INTO stats_logs (owner, level, label, score) VALUES ('blue', 85, 'edge', 90.23);
INSERT INTO stats_logs (owner, level, label, score) VALUES ('cached', 30, 'open', 24.03);
