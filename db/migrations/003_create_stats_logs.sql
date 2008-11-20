-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (ratio, label, rank) VALUES (20.28, 'strict', 30);
INSERT INTO stats_logs (ratio, label, rank) VALUES (66.69, 'standard', 82);
INSERT INTO stats_logs (ratio, label, rank) VALUES (89.85, 'staging', 94);
