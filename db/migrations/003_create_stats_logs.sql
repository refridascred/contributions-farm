-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (active, weight, token, region) VALUES (2, 0.7, 'standard', 'open');
INSERT INTO stats_logs (active, weight, token, region) VALUES (95, 59.31, 'strict', 'primary');
INSERT INTO stats_logs (active, weight, token, region) VALUES (9, 84.78, 'standard', 'open');
