-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    level INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, level) VALUES ('edge', 63);
INSERT INTO commits_records (label, level) VALUES ('primary', 36);
INSERT INTO commits_records (label, level) VALUES ('eu-west', 31);
