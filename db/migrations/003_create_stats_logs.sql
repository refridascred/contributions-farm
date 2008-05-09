-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (rank, label, active) VALUES (35, 'strict', 73);
INSERT INTO stats_logs (rank, label, active) VALUES (58, 'stable', 21);
INSERT INTO stats_logs (rank, label, active) VALUES (89, 'cached', 30);
