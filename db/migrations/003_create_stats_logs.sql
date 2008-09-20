-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, weight, rank, owner) VALUES ('standard', 89.84, 84, 'legacy');
INSERT INTO stats_logs (state, weight, rank, owner) VALUES ('open', 64.63, 52, 'staging');
