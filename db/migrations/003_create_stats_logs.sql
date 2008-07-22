-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (rank, active, level, count) VALUES (16, 94, 42, 82);
INSERT INTO stats_logs (rank, active, level, count) VALUES (95, 55, 91, 58);
INSERT INTO stats_logs (rank, active, level, count) VALUES (95, 43, 83, 83);
