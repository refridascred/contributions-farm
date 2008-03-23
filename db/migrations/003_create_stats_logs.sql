-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (rank, state, region, owner) VALUES (61, 'fallback', 'fallback', 'strict');
INSERT INTO stats_logs (rank, state, region, owner) VALUES (46, 'primary', 'fallback', 'fallback');
