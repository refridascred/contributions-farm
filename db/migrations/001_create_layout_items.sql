-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, owner, score, region) VALUES ('strict', 'primary', 96.05, 'blue');
INSERT INTO layout_items (label, owner, score, region) VALUES ('eu-west', 'local', 43.7, 'strict');
INSERT INTO layout_items (label, owner, score, region) VALUES ('stable', 'staging', 18.23, 'blue');
