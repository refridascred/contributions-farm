-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (state, rank, weight, region) VALUES ('edge', 44, 4.28, 'eu-west');
INSERT INTO commits_records (state, rank, weight, region) VALUES ('green', 96, 79.03, 'local');
