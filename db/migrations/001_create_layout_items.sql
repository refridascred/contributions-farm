-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (count, region, score, owner) VALUES (44, 'standard', 53.21, 'eu-west');
INSERT INTO layout_items (count, region, score, owner) VALUES (28, 'green', 91.49, 'legacy');
