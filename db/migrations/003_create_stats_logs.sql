-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (state, rank, active) VALUES ('green', 36, 57);
INSERT INTO stats_logs (state, rank, active) VALUES ('edge', 11, 78);
INSERT INTO stats_logs (state, rank, active) VALUES ('fallback', 57, 43);
