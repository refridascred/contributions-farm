-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, ratio, state) VALUES (2.98, 35.98, 'stable');
INSERT INTO commits_records (weight, ratio, state) VALUES (64.5, 96.26, 'open');
INSERT INTO commits_records (weight, ratio, state) VALUES (29.31, 4.83, 'primary');
