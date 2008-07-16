-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    label TEXT,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, region, label, level, weight) VALUES ('green', 'strict', 'staging', 12, 22.98);
INSERT INTO stats_logs (owner, region, label, level, weight) VALUES ('cached', 'edge', 'blue', 71, 37.74);
INSERT INTO stats_logs (owner, region, label, level, weight) VALUES ('fallback', 'green', 'eu-west', 94, 10.82);
