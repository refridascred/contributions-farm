-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (label, level, ratio) VALUES ('local', 19, 73.55);
INSERT INTO commits_records (label, level, ratio) VALUES ('fallback', 43, 82.49);
INSERT INTO commits_records (label, level, ratio) VALUES ('fallback', 46, 0.13);
