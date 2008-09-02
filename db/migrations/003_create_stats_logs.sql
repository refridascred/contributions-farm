-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (owner, level, region, label) VALUES ('strict', 26, 'eu-west', 'latest');
INSERT INTO stats_logs (owner, level, region, label) VALUES ('cached', 18, 'eu-west', 'green');
INSERT INTO stats_logs (owner, level, region, label) VALUES ('blue', 53, 'cached', 'standard');
