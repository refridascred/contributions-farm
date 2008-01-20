-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (owner, label, level) VALUES ('latest', 'standard', 8);
INSERT INTO commits_records (owner, label, level) VALUES ('cached', 'green', 31);
INSERT INTO commits_records (owner, label, level) VALUES ('strict', 'eu-west', 76);
