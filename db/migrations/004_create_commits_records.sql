-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    rank INTEGER,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, level, rank, label) VALUES ('primary', 28, 91, 'cached');
INSERT INTO commits_records (token, level, rank, label) VALUES ('blue', 40, 34, 'cached');
INSERT INTO commits_records (token, level, rank, label) VALUES ('cached', 77, 50, 'local');
