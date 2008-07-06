-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (token, owner, weight, level) VALUES ('legacy', 'latest', 32.24, 66);
INSERT INTO stats_logs (token, owner, weight, level) VALUES ('green', 'open', 85.72, 76);
INSERT INTO stats_logs (token, owner, weight, level) VALUES ('open', 'stable', 75.39, 99);
