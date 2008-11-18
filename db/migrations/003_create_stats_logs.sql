-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (active, label, weight, rank) VALUES (27, 'strict', 97.64, 8);
INSERT INTO stats_logs (active, label, weight, rank) VALUES (97, 'blue', 69.22, 86);
INSERT INTO stats_logs (active, label, weight, rank) VALUES (29, 'local', 56.79, 78);
