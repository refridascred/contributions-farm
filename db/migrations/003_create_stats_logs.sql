-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (state, weight, owner) VALUES ('cached', 25.75, 'local');
INSERT INTO stats_logs (state, weight, owner) VALUES ('blue', 16.2, 'staging');
