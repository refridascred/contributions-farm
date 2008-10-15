-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    owner TEXT NOT NULL,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (token, level, owner, label, weight) VALUES ('stable', 10, 'strict', 'primary', 55.28);
INSERT INTO stats_logs (token, level, owner, label, weight) VALUES ('fallback', 51, 'local', 'blue', 35.15);
