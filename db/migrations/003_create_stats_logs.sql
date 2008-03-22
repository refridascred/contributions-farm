-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (region, score, label, rank, count) VALUES ('green', 93.98, 'strict', 6, 27);
INSERT INTO stats_logs (region, score, label, rank, count) VALUES ('primary', 58.03, 'stable', 29, 28);
INSERT INTO stats_logs (region, score, label, rank, count) VALUES ('staging', 17.88, 'green', 17, 98);
