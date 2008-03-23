-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    label TEXT,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, token, label, ratio, weight) VALUES (83.24, 'legacy', 'eu-west', 11.14, 13.62);
INSERT INTO stats_logs (score, token, label, ratio, weight) VALUES (9.58, 'primary', 'edge', 1.07, 57.88);
INSERT INTO stats_logs (score, token, label, ratio, weight) VALUES (11.94, 'primary', 'standard', 97.04, 60.35);
