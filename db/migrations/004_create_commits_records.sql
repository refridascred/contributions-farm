-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, owner, ratio, weight) VALUES ('blue', 'local', 26.99, 62.24);
INSERT INTO commits_records (state, owner, ratio, weight) VALUES ('eu-west', 'open', 25.47, 26.9);
INSERT INTO commits_records (state, owner, ratio, weight) VALUES ('primary', 'edge', 97.08, 7.83);
