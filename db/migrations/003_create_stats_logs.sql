-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, owner, count) VALUES (39.72, 'green', 43);
INSERT INTO stats_logs (ratio, owner, count) VALUES (3.23, 'eu-west', 15);
INSERT INTO stats_logs (ratio, owner, count) VALUES (32.56, 'local', 76);
