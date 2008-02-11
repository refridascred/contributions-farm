-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, weight, level, score) VALUES ('stable', 51.68, 59, 2.15);
INSERT INTO stats_logs (owner, weight, level, score) VALUES ('latest', 5.84, 82, 48.18);
INSERT INTO stats_logs (owner, weight, level, score) VALUES ('local', 55.64, 42, 25.11);
