-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (rank, active, label) VALUES (80, 57, 'eu-west');
INSERT INTO stats_logs (rank, active, label) VALUES (19, 60, 'standard');
INSERT INTO stats_logs (rank, active, label) VALUES (64, 25, 'primary');
