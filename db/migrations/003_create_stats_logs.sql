-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (rank, state, ratio, count) VALUES (44, 'fallback', 10.89, 50);
INSERT INTO stats_logs (rank, state, ratio, count) VALUES (90, 'eu-west', 32.58, 97);
INSERT INTO stats_logs (rank, state, ratio, count) VALUES (20, 'local', 60.3, 12);
