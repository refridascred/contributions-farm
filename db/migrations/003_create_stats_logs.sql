-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (token, level, owner, weight) VALUES ('legacy', 85, 'strict', 97.83);
INSERT INTO stats_logs (token, level, owner, weight) VALUES ('latest', 38, 'blue', 31.36);
