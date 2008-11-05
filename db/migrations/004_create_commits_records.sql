-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (token, label, ratio) VALUES ('eu-west', 'blue', 65.28);
INSERT INTO commits_records (token, label, ratio) VALUES ('blue', 'open', 83.74);
