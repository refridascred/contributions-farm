-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (owner, score, weight, active) VALUES ('legacy', 65.6, 66.87, 0);
INSERT INTO stats_logs (owner, score, weight, active) VALUES ('cached', 6.67, 54.23, 41);
INSERT INTO stats_logs (owner, score, weight, active) VALUES ('green', 45.8, 11.54, 56);
