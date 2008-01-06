-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, level, label) VALUES (45, 49, 'eu-west');
INSERT INTO layout_items (count, level, label) VALUES (27, 68, 'green');
INSERT INTO layout_items (count, level, label) VALUES (77, 51, 'green');
