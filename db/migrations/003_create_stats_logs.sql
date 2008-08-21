-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (region, count, active, label, rank) VALUES ('fallback', 27, 69, 'local', 42);
INSERT INTO stats_logs (region, count, active, label, rank) VALUES ('staging', 40, 89, 'open', 11);
INSERT INTO stats_logs (region, count, active, label, rank) VALUES ('cached', 38, 14, 'edge', 67);
