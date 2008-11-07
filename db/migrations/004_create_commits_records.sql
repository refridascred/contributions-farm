-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (weight, owner, ratio, state) VALUES (7.79, 'green', 58.12, 'strict');
INSERT INTO commits_records (weight, owner, ratio, state) VALUES (37.73, 'staging', 15.18, 'stable');
