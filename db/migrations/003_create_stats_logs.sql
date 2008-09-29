-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (region, weight, level, label) VALUES ('strict', 68.11, 89, 'green');
INSERT INTO stats_logs (region, weight, level, label) VALUES ('eu-west', 30.87, 63, 'eu-west');
