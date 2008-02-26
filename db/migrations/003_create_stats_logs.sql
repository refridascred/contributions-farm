-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (region, score, rank, active, label) VALUES ('strict', 24.6, 13, 81, 'cached');
INSERT INTO stats_logs (region, score, rank, active, label) VALUES ('legacy', 83.38, 73, 74, 'stable');
