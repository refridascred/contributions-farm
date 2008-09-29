-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (token, level, owner, weight) VALUES ('fallback', 60, 'open', 87.06);
INSERT INTO stats_logs (token, level, owner, weight) VALUES ('eu-west', 49, 'standard', 96.24);
INSERT INTO stats_logs (token, level, owner, weight) VALUES ('stable', 90, 'stable', 38.15);
