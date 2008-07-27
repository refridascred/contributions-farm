-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, region, label, level) VALUES ('strict', 'edge', 'legacy', 20);
INSERT INTO stats_logs (owner, region, label, level) VALUES ('stable', 'eu-west', 'cached', 17);
INSERT INTO stats_logs (owner, region, label, level) VALUES ('latest', 'primary', 'standard', 5);
