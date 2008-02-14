-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (state, rank, level) VALUES ('legacy', 37, 30);
INSERT INTO stats_logs (state, rank, level) VALUES ('legacy', 25, 33);
INSERT INTO stats_logs (state, rank, level) VALUES ('cached', 55, 81);
