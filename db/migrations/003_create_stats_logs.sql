-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, count, rank, level) VALUES ('edge', 26, 18, 82);
INSERT INTO stats_logs (state, count, rank, level) VALUES ('primary', 28, 21, 69);
INSERT INTO stats_logs (state, count, rank, level) VALUES ('edge', 55, 55, 28);
