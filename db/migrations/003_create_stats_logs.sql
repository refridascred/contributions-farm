-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (region, rank, active, score, level) VALUES ('latest', 47, 80, 15.99, 96);
INSERT INTO stats_logs (region, rank, active, score, level) VALUES ('primary', 4, 16, 29.16, 9);
INSERT INTO stats_logs (region, rank, active, score, level) VALUES ('primary', 75, 51, 2.41, 3);
