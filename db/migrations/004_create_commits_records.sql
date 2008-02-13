-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (score, ratio, state, owner) VALUES (94.65, 19.67, 'strict', 'strict');
INSERT INTO commits_records (score, ratio, state, owner) VALUES (95.55, 26.67, 'eu-west', 'standard');
INSERT INTO commits_records (score, ratio, state, owner) VALUES (89.4, 75.37, 'blue', 'blue');
