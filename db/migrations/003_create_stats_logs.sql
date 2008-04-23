-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, label, active) VALUES (31, 'green', 49);
INSERT INTO stats_logs (count, label, active) VALUES (50, 'legacy', 42);
INSERT INTO stats_logs (count, label, active) VALUES (4, 'strict', 86);
