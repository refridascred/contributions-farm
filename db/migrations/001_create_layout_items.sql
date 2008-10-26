-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (active, count, token, ratio) VALUES (10, 11, 'local', 79.6);
INSERT INTO layout_items (active, count, token, ratio) VALUES (73, 78, 'standard', 28.95);
INSERT INTO layout_items (active, count, token, ratio) VALUES (13, 84, 'primary', 69.45);
