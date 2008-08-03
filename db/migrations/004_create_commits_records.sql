-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    label TEXT,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, rank, label, ratio) VALUES ('cached', 70, 'fallback', 68.79);
INSERT INTO commits_records (token, rank, label, ratio) VALUES ('latest', 75, 'primary', 58.79);
