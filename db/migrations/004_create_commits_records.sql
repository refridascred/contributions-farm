-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (ratio, label, count, state) VALUES (15.53, 'eu-west', 29, 'green');
INSERT INTO commits_records (ratio, label, count, state) VALUES (22.24, 'staging', 55, 'cached');
