-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (rank, label, score) VALUES (1, 'standard', 81.75);
INSERT INTO stats_logs (rank, label, score) VALUES (92, 'fallback', 28.48);
INSERT INTO stats_logs (rank, label, score) VALUES (43, 'blue', 71.58);
