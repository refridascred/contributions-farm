-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (rank, active) VALUES (15, 48);
INSERT INTO stats_logs (rank, active) VALUES (17, 40);
INSERT INTO stats_logs (rank, active) VALUES (56, 26);
