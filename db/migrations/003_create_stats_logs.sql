-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (count, label, rank, state) VALUES (7, 'strict', 59, 'legacy');
INSERT INTO stats_logs (count, label, rank, state) VALUES (91, 'primary', 89, 'primary');
INSERT INTO stats_logs (count, label, rank, state) VALUES (70, 'local', 51, 'eu-west');
