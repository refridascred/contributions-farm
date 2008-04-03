-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (state, score, rank) VALUES ('eu-west', 97.99, 87);
INSERT INTO stats_logs (state, score, rank) VALUES ('primary', 42.96, 13);
INSERT INTO stats_logs (state, score, rank) VALUES ('cached', 8.98, 72);
