-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (state, rank, ratio, weight) VALUES ('local', 74, 53.33, 80.05);
INSERT INTO commits_records (state, rank, ratio, weight) VALUES ('cached', 67, 40.66, 77.96);
INSERT INTO commits_records (state, rank, ratio, weight) VALUES ('blue', 90, 67.0, 45.27);
