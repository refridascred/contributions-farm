-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    owner TEXT NOT NULL,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (level, ratio, owner, token, label) VALUES (85, 76.4, 'eu-west', 'blue', 'blue');
INSERT INTO stats_logs (level, ratio, owner, token, label) VALUES (41, 67.4, 'latest', 'legacy', 'primary');
