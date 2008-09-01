-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (rank, label, ratio) VALUES (80, 'open', 88.5);
INSERT INTO stats_logs (rank, label, ratio) VALUES (25, 'latest', 57.45);
