-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (level, state, rank) VALUES (36, 'staging', 94);
INSERT INTO stats_logs (level, state, rank) VALUES (7, 'cached', 19);
INSERT INTO stats_logs (level, state, rank) VALUES (18, 'open', 63);
