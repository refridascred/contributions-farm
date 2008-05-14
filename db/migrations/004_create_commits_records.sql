-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (owner, token, level, weight) VALUES ('staging', 'green', 17, 52.41);
INSERT INTO commits_records (owner, token, level, weight) VALUES ('stable', 'blue', 51, 53.3);
