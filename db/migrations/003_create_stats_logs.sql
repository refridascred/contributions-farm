-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    weight REAL,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (score, region, weight, label, level) VALUES (81.81, 'cached', 55.82, 'local', 2);
INSERT INTO stats_logs (score, region, weight, label, level) VALUES (43.04, 'green', 87.41, 'legacy', 21);
