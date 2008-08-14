-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (owner, ratio, state) VALUES ('cached', 40.57, 'latest');
INSERT INTO commits_records (owner, ratio, state) VALUES ('strict', 54.77, 'standard');
INSERT INTO commits_records (owner, ratio, state) VALUES ('standard', 5.31, 'primary');
