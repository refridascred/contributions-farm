-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    token TEXT,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, level, token, rank, weight) VALUES ('latest', 59, 'cached', 19, 9.13);
INSERT INTO stats_logs (state, level, token, rank, weight) VALUES ('strict', 0, 'strict', 69, 80.31);
INSERT INTO stats_logs (state, level, token, rank, weight) VALUES ('staging', 37, 'latest', 71, 27.74);
