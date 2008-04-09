-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, ratio, state) VALUES (87.31, 55.68, 'strict');
INSERT INTO commits_records (weight, ratio, state) VALUES (33.89, 85.58, 'green');
INSERT INTO commits_records (weight, ratio, state) VALUES (45.59, 58.51, 'open');
