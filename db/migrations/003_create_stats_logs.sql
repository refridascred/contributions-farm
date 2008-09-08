-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, active, label, rank) VALUES (97, 74, 'latest', 79);
INSERT INTO stats_logs (count, active, label, rank) VALUES (1, 71, 'edge', 94);
INSERT INTO stats_logs (count, active, label, rank) VALUES (85, 42, 'green', 24);
