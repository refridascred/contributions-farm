-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (weight, owner, ratio, score) VALUES (89.89, 'fallback', 32.95, 44.03);
INSERT INTO stats_logs (weight, owner, ratio, score) VALUES (10.78, 'standard', 17.41, 53.11);
