-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (active, score, region, label) VALUES (54, 52.94, 'primary', 'blue');
INSERT INTO stats_logs (active, score, region, label) VALUES (97, 50.64, 'primary', 'eu-west');
INSERT INTO stats_logs (active, score, region, label) VALUES (35, 78.74, 'latest', 'cached');
