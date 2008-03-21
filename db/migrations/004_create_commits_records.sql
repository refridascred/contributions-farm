-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (region, count, token, weight) VALUES ('latest', 89, 'standard', 9.36);
INSERT INTO commits_records (region, count, token, weight) VALUES ('standard', 34, 'cached', 32.76);
INSERT INTO commits_records (region, count, token, weight) VALUES ('legacy', 68, 'eu-west', 90.3);
