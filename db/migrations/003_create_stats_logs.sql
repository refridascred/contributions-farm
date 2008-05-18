-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (score, region, label, weight) VALUES (78.2, 'strict', 'latest', 54.02);
INSERT INTO stats_logs (score, region, label, weight) VALUES (1.29, 'cached', 'blue', 44.87);
INSERT INTO stats_logs (score, region, label, weight) VALUES (15.55, 'open', 'standard', 64.91);
