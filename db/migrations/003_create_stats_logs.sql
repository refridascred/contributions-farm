-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (weight, label, score, rank) VALUES (69.82, 'open', 74.07, 61);
INSERT INTO stats_logs (weight, label, score, rank) VALUES (2.63, 'latest', 21.16, 41);
