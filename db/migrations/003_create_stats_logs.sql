-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    weight REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (rank, label, weight) VALUES (58, 'primary', 31.97);
INSERT INTO stats_logs (rank, label, weight) VALUES (32, 'blue', 33.65);
INSERT INTO stats_logs (rank, label, weight) VALUES (3, 'fallback', 46.06);
