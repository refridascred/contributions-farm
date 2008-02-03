-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (region, state, label) VALUES ('eu-west', 'fallback', 'fallback');
INSERT INTO commits_records (region, state, label) VALUES ('legacy', 'blue', 'blue');
INSERT INTO commits_records (region, state, label) VALUES ('stable', 'primary', 'latest');
