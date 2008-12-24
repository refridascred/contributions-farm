-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, ratio, level, count) VALUES ('latest', 81.33, 77, 68);
INSERT INTO stats_logs (token, ratio, level, count) VALUES ('stable', 76.76, 44, 69);
