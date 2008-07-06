-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (owner, level, token, ratio) VALUES ('edge', 26, 'standard', 19.76);
INSERT INTO stats_logs (owner, level, token, ratio) VALUES ('legacy', 60, 'green', 31.13);
INSERT INTO stats_logs (owner, level, token, ratio) VALUES ('open', 88, 'primary', 68.36);
