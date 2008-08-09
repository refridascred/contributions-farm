-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (ratio, weight, state, owner) VALUES (17.62, 11.43, 'eu-west', 'blue');
INSERT INTO commits_records (ratio, weight, state, owner) VALUES (34.1, 26.43, 'open', 'legacy');
