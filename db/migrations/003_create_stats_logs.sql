-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (label, state, rank, level) VALUES ('fallback', 'local', 0, 28);
