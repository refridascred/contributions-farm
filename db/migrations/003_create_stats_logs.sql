-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    rank INTEGER,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (state, owner, rank, weight, ratio) VALUES ('staging', 'stable', 90, 33.25, 2.79);
INSERT INTO stats_logs (state, owner, rank, weight, ratio) VALUES ('green', 'open', 65, 71.29, 35.72);
INSERT INTO stats_logs (state, owner, rank, weight, ratio) VALUES ('local', 'cached', 43, 38.04, 5.24);
