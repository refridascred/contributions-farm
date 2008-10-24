-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, weight, ratio) VALUES ('standard', 59.88, 44.01);
INSERT INTO stats_logs (state, weight, ratio) VALUES ('standard', 12.81, 95.43);
INSERT INTO stats_logs (state, weight, ratio) VALUES ('stable', 5.09, 25.62);
