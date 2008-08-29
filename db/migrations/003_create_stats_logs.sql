-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (owner, ratio, rank, count, state) VALUES ('eu-west', 55.95, 21, 37, 'primary');
INSERT INTO stats_logs (owner, ratio, rank, count, state) VALUES ('strict', 51.45, 28, 66, 'staging');
INSERT INTO stats_logs (owner, ratio, rank, count, state) VALUES ('primary', 10.2, 78, 69, 'eu-west');
