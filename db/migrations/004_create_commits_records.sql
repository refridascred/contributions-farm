-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (label, weight, state) VALUES ('cached', 87.18, 'latest');
INSERT INTO commits_records (label, weight, state) VALUES ('cached', 42.04, 'open');
INSERT INTO commits_records (label, weight, state) VALUES ('stable', 70.26, 'open');
