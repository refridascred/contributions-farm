-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, weight, ratio) VALUES ('standard', 54.5, 5.68);
INSERT INTO commits_records (token, weight, ratio) VALUES ('cached', 92.48, 27.5);
INSERT INTO commits_records (token, weight, ratio) VALUES ('fallback', 88.8, 65.74);
