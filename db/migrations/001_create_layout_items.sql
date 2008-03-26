-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (level, token, rank) VALUES (35, 'green', 30);
INSERT INTO layout_items (level, token, rank) VALUES (57, 'fallback', 92);
INSERT INTO layout_items (level, token, rank) VALUES (52, 'green', 87);
