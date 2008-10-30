-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (label, active, rank) VALUES ('primary', 32, 17);
INSERT INTO stats_logs (label, active, rank) VALUES ('stable', 87, 84);
INSERT INTO stats_logs (label, active, rank) VALUES ('cached', 15, 39);
