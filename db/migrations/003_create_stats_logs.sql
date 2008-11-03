-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, owner, level, weight) VALUES (59.75, 'latest', 50, 66.0);
INSERT INTO stats_logs (score, owner, level, weight) VALUES (51.56, 'primary', 32, 8.56);
