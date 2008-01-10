-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, weight, score, owner) VALUES ('legacy', 61.88, 57.35, 'stable');
INSERT INTO commits_records (state, weight, score, owner) VALUES ('latest', 53.25, 26.24, 'edge');
INSERT INTO commits_records (state, weight, score, owner) VALUES ('legacy', 91.23, 9.23, 'edge');
