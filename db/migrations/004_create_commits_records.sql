-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (region, label, ratio, state) VALUES ('eu-west', 'blue', 72.4, 'strict');
INSERT INTO commits_records (region, label, ratio, state) VALUES ('standard', 'local', 73.76, 'staging');
INSERT INTO commits_records (region, label, ratio, state) VALUES ('blue', 'open', 14.66, 'fallback');
