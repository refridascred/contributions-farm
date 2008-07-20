-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (owner, score, active, level) VALUES ('local', 58.25, 76, 18);
INSERT INTO stats_logs (owner, score, active, level) VALUES ('cached', 54.76, 13, 64);
INSERT INTO stats_logs (owner, score, active, level) VALUES ('primary', 77.05, 96, 73);
