-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (rank, active, level) VALUES (46, 89, 14);
INSERT INTO stats_logs (rank, active, level) VALUES (48, 9, 80);
INSERT INTO stats_logs (rank, active, level) VALUES (66, 11, 90);
