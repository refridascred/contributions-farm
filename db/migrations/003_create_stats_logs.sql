-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, active, rank, ratio) VALUES ('strict', 6, 58, 73.11);
INSERT INTO stats_logs (state, active, rank, ratio) VALUES ('fallback', 37, 56, 31.89);
INSERT INTO stats_logs (state, active, rank, ratio) VALUES ('staging', 49, 15, 43.24);
