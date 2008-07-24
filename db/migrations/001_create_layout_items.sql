-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (weight, token, count) VALUES (42.12, 'legacy', 70);
INSERT INTO layout_items (weight, token, count) VALUES (62.13, 'eu-west', 86);
INSERT INTO layout_items (weight, token, count) VALUES (41.18, 'primary', 92);
