-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (active, token, region) VALUES (58, 'primary', 'strict');
INSERT INTO layout_items (active, token, region) VALUES (33, 'strict', 'cached');
INSERT INTO layout_items (active, token, region) VALUES (40, 'open', 'local');
