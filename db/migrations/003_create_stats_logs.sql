-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (token, level, ratio) VALUES ('eu-west', 23, 17.97);
INSERT INTO stats_logs (token, level, ratio) VALUES ('standard', 78, 89.43);
INSERT INTO stats_logs (token, level, ratio) VALUES ('stable', 40, 67.16);
