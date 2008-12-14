-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (rank, label, score) VALUES (79, 'local', 28.62);
INSERT INTO stats_logs (rank, label, score) VALUES (23, 'cached', 86.36);
INSERT INTO stats_logs (rank, label, score) VALUES (71, 'stable', 50.26);
