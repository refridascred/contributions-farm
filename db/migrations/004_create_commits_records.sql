-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    label TEXT,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (region, level, label, token) VALUES ('staging', 28, 'eu-west', 'legacy');
INSERT INTO commits_records (region, level, label, token) VALUES ('eu-west', 16, 'local', 'eu-west');
