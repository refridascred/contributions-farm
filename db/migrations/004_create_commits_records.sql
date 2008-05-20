-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    token TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (owner, weight, token, level, state) VALUES ('fallback', 11.24, 'staging', 35, 'staging');
INSERT INTO commits_records (owner, weight, token, level, state) VALUES ('open', 70.0, 'stable', 55, 'green');
INSERT INTO commits_records (owner, weight, token, level, state) VALUES ('stable', 55.62, 'staging', 23, 'fallback');
