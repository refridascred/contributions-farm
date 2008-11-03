-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (rank, weight, owner, state, label) VALUES (17, 25.59, 'green', 'standard', 'fallback');
INSERT INTO stats_logs (rank, weight, owner, state, label) VALUES (88, 67.36, 'legacy', 'eu-west', 'legacy');
