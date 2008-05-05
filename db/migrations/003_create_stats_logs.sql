-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (level, region, active, weight, owner) VALUES (76, 'cached', 57, 89.85, 'staging');
INSERT INTO stats_logs (level, region, active, weight, owner) VALUES (91, 'blue', 6, 10.98, 'stable');
INSERT INTO stats_logs (level, region, active, weight, owner) VALUES (88, 'eu-west', 34, 21.07, 'cached');
