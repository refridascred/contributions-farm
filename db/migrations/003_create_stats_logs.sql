-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (rank, token, active, label, level) VALUES (7, 'standard', 18, 'blue', 62);
INSERT INTO stats_logs (rank, token, active, label, level) VALUES (62, 'stable', 46, 'cached', 78);
