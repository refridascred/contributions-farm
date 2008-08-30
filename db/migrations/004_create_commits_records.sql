-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    weight REAL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (level, owner, weight, token, state) VALUES (51, 'blue', 4.01, 'open', 'local');
INSERT INTO commits_records (level, owner, weight, token, state) VALUES (12, 'green', 56.15, 'legacy', 'cached');
INSERT INTO commits_records (level, owner, weight, token, state) VALUES (27, 'blue', 68.32, 'edge', 'edge');
