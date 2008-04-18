-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (owner, token, state, weight, rank) VALUES ('legacy', 'primary', 'green', 27.36, 55);
INSERT INTO stats_logs (owner, token, state, weight, rank) VALUES ('blue', 'local', 'local', 97.84, 83);
