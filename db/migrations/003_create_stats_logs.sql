-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (rank, count, label, score) VALUES (20, 15, 'local', 96.87);
INSERT INTO stats_logs (rank, count, label, score) VALUES (46, 92, 'latest', 65.55);
INSERT INTO stats_logs (rank, count, label, score) VALUES (69, 19, 'latest', 64.31);
