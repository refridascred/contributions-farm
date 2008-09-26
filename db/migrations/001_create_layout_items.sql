-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, count, weight) VALUES ('cached', 3, 56.18);
INSERT INTO layout_items (token, count, weight) VALUES ('legacy', 89, 78.61);
INSERT INTO layout_items (token, count, weight) VALUES ('green', 56, 72.18);
