-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (label, active, level) VALUES ('open', 4, 37);
INSERT INTO commits_records (label, active, level) VALUES ('green', 12, 96);
INSERT INTO commits_records (label, active, level) VALUES ('legacy', 69, 97);
