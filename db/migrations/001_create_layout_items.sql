-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    owner TEXT NOT NULL,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (count, region, owner, label, token) VALUES (2, 'strict', 'cached', 'blue', 'cached');
INSERT INTO layout_items (count, region, owner, label, token) VALUES (58, 'stable', 'latest', 'green', 'blue');
