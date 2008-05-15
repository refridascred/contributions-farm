-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (weight, rank, state) VALUES (37.4, 5, 'edge');
INSERT INTO commits_records (weight, rank, state) VALUES (89.56, 30, 'latest');
