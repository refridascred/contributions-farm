-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (region, ratio, label, state) VALUES ('stable', 29.53, 'local', 'cached');
INSERT INTO commits_records (region, ratio, label, state) VALUES ('green', 28.27, 'legacy', 'blue');
INSERT INTO commits_records (region, ratio, label, state) VALUES ('blue', 2.52, 'latest', 'strict');
