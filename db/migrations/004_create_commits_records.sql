-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, token, weight) VALUES ('eu-west', 'primary', 6.52);
INSERT INTO commits_records (label, token, weight) VALUES ('green', 'open', 23.35);
INSERT INTO commits_records (label, token, weight) VALUES ('stable', 'strict', 33.24);
