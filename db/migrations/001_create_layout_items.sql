-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, token, count, label) VALUES (84, 'strict', 97, 'strict');
INSERT INTO layout_items (active, token, count, label) VALUES (23, 'blue', 70, 'cached');
INSERT INTO layout_items (active, token, count, label) VALUES (47, 'eu-west', 3, 'eu-west');
