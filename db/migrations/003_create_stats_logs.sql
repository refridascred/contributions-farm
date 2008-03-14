-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, rank, weight, active, region) VALUES ('blue', 24, 34.89, 63, 'standard');
INSERT INTO stats_logs (state, rank, weight, active, region) VALUES ('strict', 93, 25.07, 54, 'open');
