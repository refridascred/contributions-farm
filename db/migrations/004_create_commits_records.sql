-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (state, weight, score, label) VALUES ('eu-west', 47.83, 39.55, 'latest');
INSERT INTO commits_records (state, weight, score, label) VALUES ('local', 15.34, 66.84, 'strict');
INSERT INTO commits_records (state, weight, score, label) VALUES ('local', 56.54, 30.76, 'standard');
