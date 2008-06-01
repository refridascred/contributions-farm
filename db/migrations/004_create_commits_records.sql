-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, state, ratio) VALUES (15.6, 'open', 96.68);
INSERT INTO commits_records (weight, state, ratio) VALUES (42.03, 'blue', 72.88);
INSERT INTO commits_records (weight, state, ratio) VALUES (80.59, 'legacy', 9.11);
