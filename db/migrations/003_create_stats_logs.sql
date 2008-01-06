-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    level INTEGER,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (owner, ratio, level, token, count) VALUES ('standard', 10.75, 0, 'latest', 85);
INSERT INTO stats_logs (owner, ratio, level, token, count) VALUES ('primary', 37.42, 85, 'latest', 94);
