-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (owner, score, active, token, weight) VALUES ('local', 28.2, 17, 'strict', 32.71);
INSERT INTO stats_logs (owner, score, active, token, weight) VALUES ('edge', 8.2, 87, 'fallback', 13.09);
