-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    ratio REAL,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (weight, owner, ratio, label, level) VALUES (37.24, 'cached', 20.12, 'standard', 81);
INSERT INTO stats_logs (weight, owner, ratio, label, level) VALUES (88.32, 'fallback', 16.42, 'primary', 52);
INSERT INTO stats_logs (weight, owner, ratio, label, level) VALUES (25.36, 'primary', 64.71, 'strict', 89);
