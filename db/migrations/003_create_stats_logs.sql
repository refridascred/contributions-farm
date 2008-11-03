-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (state, rank, weight) VALUES ('strict', 35, 55.2);
INSERT INTO stats_logs (state, rank, weight) VALUES ('local', 13, 85.56);
INSERT INTO stats_logs (state, rank, weight) VALUES ('standard', 93, 94.95);
