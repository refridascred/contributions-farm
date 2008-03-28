-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (owner, state, score, rank, weight) VALUES ('edge', 'eu-west', 7.02, 69, 48.33);
INSERT INTO commits_records (owner, state, score, rank, weight) VALUES ('edge', 'primary', 61.76, 33, 64.52);
