-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (rank, label, state, count) VALUES (35, 'primary', 'strict', 91);
INSERT INTO stats_logs (rank, label, state, count) VALUES (94, 'staging', 'stable', 85);
INSERT INTO stats_logs (rank, label, state, count) VALUES (5, 'latest', 'fallback', 24);
