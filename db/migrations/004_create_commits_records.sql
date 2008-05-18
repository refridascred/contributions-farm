-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    rank INTEGER,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (state, ratio, rank, weight, region) VALUES ('cached', 70.21, 73, 74.1, 'local');
INSERT INTO commits_records (state, ratio, rank, weight, region) VALUES ('strict', 92.23, 15, 47.16, 'legacy');
INSERT INTO commits_records (state, ratio, rank, weight, region) VALUES ('primary', 5.07, 53, 4.86, 'open');
