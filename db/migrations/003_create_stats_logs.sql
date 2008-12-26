-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (state, label, rank, level) VALUES ('strict', 'green', 7, 71);
INSERT INTO stats_logs (state, label, rank, level) VALUES ('cached', 'green', 27, 92);
INSERT INTO stats_logs (state, label, rank, level) VALUES ('stable', 'open', 71, 74);
