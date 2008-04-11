-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (rank, label, active, level) VALUES (92, 'green', 96, 65);
INSERT INTO stats_logs (rank, label, active, level) VALUES (51, 'edge', 55, 3);
