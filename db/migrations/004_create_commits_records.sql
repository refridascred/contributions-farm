-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, active, region) VALUES ('eu-west', 9, 'open');
INSERT INTO commits_records (state, active, region) VALUES ('local', 92, 'stable');
INSERT INTO commits_records (state, active, region) VALUES ('latest', 41, 'green');
