-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (label, state, weight, owner) VALUES ('open', 'blue', 38.38, 'local');
INSERT INTO commits_records (label, state, weight, owner) VALUES ('stable', 'green', 5.67, 'latest');
INSERT INTO commits_records (label, state, weight, owner) VALUES ('fallback', 'strict', 63.31, 'green');
