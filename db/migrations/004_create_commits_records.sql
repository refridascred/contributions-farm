-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, weight, rank, owner) VALUES ('eu-west', 15.9, 71, 'green');
INSERT INTO commits_records (state, weight, rank, owner) VALUES ('green', 67.16, 2, 'edge');
INSERT INTO commits_records (state, weight, rank, owner) VALUES ('staging', 18.93, 71, 'latest');
