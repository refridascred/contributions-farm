-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, ratio, count, weight) VALUES ('edge', 52.73, 33, 79.3);
INSERT INTO commits_records (state, ratio, count, weight) VALUES ('legacy', 2.39, 23, 12.18);
INSERT INTO commits_records (state, ratio, count, weight) VALUES ('blue', 68.01, 71, 44.1);
