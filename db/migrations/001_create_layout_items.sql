-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (region, score, active, owner) VALUES ('fallback', 31.43, 68, 'standard');
INSERT INTO layout_items (region, score, active, owner) VALUES ('latest', 6.43, 33, 'latest');
INSERT INTO layout_items (region, score, active, owner) VALUES ('eu-west', 9.78, 41, 'green');
