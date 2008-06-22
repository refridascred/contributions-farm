-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (owner, ratio, weight, state) VALUES ('cached', 33.96, 16.25, 'edge');
INSERT INTO commits_records (owner, ratio, weight, state) VALUES ('eu-west', 96.29, 63.86, 'primary');
