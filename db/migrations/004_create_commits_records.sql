-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (ratio, state, weight, label) VALUES (73.69, 'eu-west', 12.33, 'blue');
INSERT INTO commits_records (ratio, state, weight, label) VALUES (94.38, 'staging', 12.37, 'latest');
INSERT INTO commits_records (ratio, state, weight, label) VALUES (85.94, 'open', 11.56, 'green');
