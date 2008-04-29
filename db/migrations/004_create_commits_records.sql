-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (token, ratio, state, active) VALUES ('fallback', 75.54, 'green', 70);
INSERT INTO commits_records (token, ratio, state, active) VALUES ('latest', 51.56, 'primary', 31);
INSERT INTO commits_records (token, ratio, state, active) VALUES ('eu-west', 38.73, 'staging', 34);
