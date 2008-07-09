-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (token, ratio, score, owner, active) VALUES ('strict', 43.99, 75.26, 'open', 2);
INSERT INTO stats_logs (token, ratio, score, owner, active) VALUES ('cached', 77.04, 17.18, 'strict', 55);
INSERT INTO stats_logs (token, ratio, score, owner, active) VALUES ('open', 29.93, 38.53, 'open', 49);
