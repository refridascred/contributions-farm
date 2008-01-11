-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, score, ratio, weight) VALUES ('open', 50.5, 41.07, 29.87);
INSERT INTO stats_logs (label, score, ratio, weight) VALUES ('latest', 8.08, 48.63, 79.92);
