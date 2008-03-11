-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    level INTEGER,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (ratio, owner, level, label) VALUES (92.92, 'legacy', 20, 'staging');
INSERT INTO stats_logs (ratio, owner, level, label) VALUES (83.26, 'latest', 61, 'staging');
INSERT INTO stats_logs (ratio, owner, level, label) VALUES (50.96, 'green', 93, 'staging');
