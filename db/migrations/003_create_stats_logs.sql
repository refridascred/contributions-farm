-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (label, rank, owner) VALUES ('green', 87, 'edge');
INSERT INTO stats_logs (label, rank, owner) VALUES ('local', 61, 'green');
INSERT INTO stats_logs (label, rank, owner) VALUES ('standard', 54, 'standard');
