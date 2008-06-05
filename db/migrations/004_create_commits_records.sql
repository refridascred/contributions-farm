-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (label, weight) VALUES ('staging', 48.69);
INSERT INTO commits_records (label, weight) VALUES ('blue', 23.47);
INSERT INTO commits_records (label, weight) VALUES ('blue', 47.17);
