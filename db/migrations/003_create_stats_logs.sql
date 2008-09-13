-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, rank) VALUES (76, 94);
INSERT INTO stats_logs (active, rank) VALUES (43, 28);
INSERT INTO stats_logs (active, rank) VALUES (56, 87);
