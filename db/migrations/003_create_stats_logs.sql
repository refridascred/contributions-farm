-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (weight, label, level) VALUES (38.97, 'strict', 12);
INSERT INTO stats_logs (weight, label, level) VALUES (37.13, 'legacy', 92);
