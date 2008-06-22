-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (label, weight, score) VALUES ('eu-west', 79.84, 33.59);
INSERT INTO stats_logs (label, weight, score) VALUES ('legacy', 90.98, 42.8);
INSERT INTO stats_logs (label, weight, score) VALUES ('green', 7.77, 76.04);
