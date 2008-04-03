-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (region, label) VALUES ('open', 'open');
INSERT INTO commits_records (region, label) VALUES ('blue', 'blue');
INSERT INTO commits_records (region, label) VALUES ('cached', 'fallback');
