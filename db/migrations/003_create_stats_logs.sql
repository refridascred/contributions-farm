-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (label, state, owner, rank) VALUES ('primary', 'fallback', 'legacy', 63);
INSERT INTO stats_logs (label, state, owner, rank) VALUES ('standard', 'standard', 'fallback', 91);
