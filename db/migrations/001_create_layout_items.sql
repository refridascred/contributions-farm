-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (count, token, level) VALUES (58, 'fallback', 37);
INSERT INTO layout_items (count, token, level) VALUES (99, 'green', 98);
INSERT INTO layout_items (count, token, level) VALUES (50, 'green', 46);
