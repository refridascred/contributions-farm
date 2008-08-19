-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (state, weight, ratio, count, owner) VALUES ('local', 49.63, 56.74, 19, 'local');
INSERT INTO commits_records (state, weight, ratio, count, owner) VALUES ('edge', 15.26, 17.64, 59, 'strict');
INSERT INTO commits_records (state, weight, ratio, count, owner) VALUES ('open', 80.19, 44.76, 75, 'open');
