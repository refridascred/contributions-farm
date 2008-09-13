-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, active, ratio) VALUES ('standard', 31, 68.73);
INSERT INTO commits_records (token, active, ratio) VALUES ('fallback', 41, 13.88);
INSERT INTO commits_records (token, active, ratio) VALUES ('eu-west', 50, 37.07);
